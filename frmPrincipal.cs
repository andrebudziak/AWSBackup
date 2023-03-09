using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Amazon.S3;
using Amazon;
using Amazon.S3.Model;
using FirebirdSql.Data.Services;
using FirebirdSql.Data.FirebirdClient;
using System.Collections;
using System.Net.Mail;
using Ionic.Zip;
using System.IO;
using System.Xml;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Threading;
using System.Diagnostics;
using Microsoft.Win32;
using FirebirdSql.Data.Isql;

namespace AWSBackup
{
    public partial class frmPrincipal : Form
    {
        SprightlySoftAWS.S3.Download MyDownload;
        System.ComponentModel.BackgroundWorker DownloadBackgroundWorker;

        SprightlySoftAWS.S3.CalculateHash MyCalculateHash;
        SprightlySoftAWS.S3.Upload MyUpload;
        System.ComponentModel.BackgroundWorker UploadBackgroundWorker;
        System.ComponentModel.BackgroundWorker CalculateHashBackgroundWorker;
        Properties.Settings MySettings;
        DataRow dr;
        Boolean v_First = false;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           this.WindowState = FormWindowState.Normal;
            // Activate the form.
            this.Activate();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            MySettings = new Properties.Settings();

            txtLog.Clear();
            txtUsuario.Text = MySettings.usuario;
            txtSenha.Text = MySettings.senha;
            txtCaminho.Text = MySettings.caminho;
            txtCaminhoBackup.Text = MySettings.caminho_backup;
            txtPortaServidor.Text = MySettings.PortaBanco;
            txtSMTP.Text = MySettings.smtp;
            txtPorta.Text = MySettings.porta;
            txtEmailEmitente.Text = MySettings.email_e;
            txtSenhaEmitente.Text = MySettings.senha_e;
            txtEmailDestinatario.Text = MySettings.email_d;
            txtContaEmail.Text = MySettings.conta_email;
            txtAWSAccessKeyId.Text = MySettings.AWSAccessKeyId;
            txtAWSSecretAccessKey.Text = MySettings.AWSSecretAccessKey;
            txtDownloadBucketName.Text = MySettings.DownloadBucketName;
            txtDownloadKeyName.Text = MySettings.DownloadKeyName;
            txtDownloadFileName.Text = MySettings.DownloadFileName;
            txtUploadFileName.Text = MySettings.UploadFileName;
            txtUploadBucketName.Text = MySettings.UploadBucketName;
            txtUploadKeyName.Text = MySettings.UploadKeyName;
            txtUploadContentType.Text = MySettings.UploadContentType;
            CheckBoxUploadMakePublic.Checked = MySettings.UploadMakePublic;
            txtServidor.Text = MySettings.servidor_banco;
            txtGfix.Text = MySettings.gfix;
            txtTempoEspera.Text = MySettings.tempo_espera;

            if (File.Exists("agenda.xml"))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("agenda.xml");
                XmlNodeReader reader = new XmlNodeReader(doc);

                dsAgenda.ReadXml(reader);
                reader.Close();
                dgvAgenda.Refresh();
            }

            if (File.Exists("arquivo.xml"))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("arquivo.xml");
                XmlNodeReader reader = new XmlNodeReader(doc);

                dsArquivo.ReadXml(reader);
                reader.Close();
                dgvArquivo.Refresh();
            }

            dr = dsAgenda.Tables[0].Select("ativo = 1").FirstOrDefault();
            if (dr != null)
            {
                if (dr["amazon"].ToString() == "1")
                {

                    dsArquivo.Tables[0].Rows.Clear();
                    MyDownload = new SprightlySoftAWS.S3.Download();
                    MyDownload.ProgressChangedEvent += MyDownload_ProgressChangedEvent;

                    DownloadBackgroundWorker = new System.ComponentModel.BackgroundWorker();
                    DownloadBackgroundWorker.DoWork += DownloadBackgroundWorker_DoWork;
                    DownloadBackgroundWorker.RunWorkerCompleted += DownloadBackgroundWorker_RunWorkerCompleted;

                    ProgressBarDownload.Value = 0;
                    LabelBytesTransfered.Text = "0 bytes / 0 bytes";


                    MyCalculateHash = new SprightlySoftAWS.S3.CalculateHash();
                    MyCalculateHash.ProgressChangedEvent += MyCalculateHash_ProgressChangedEvent;

                    MyUpload = new SprightlySoftAWS.S3.Upload();
                    MyUpload.ProgressChangedEvent += MyUpload_ProgressChangedEvent;

                    CalculateHashBackgroundWorker = new System.ComponentModel.BackgroundWorker();
                    CalculateHashBackgroundWorker.DoWork += CalculateHashBackgroundWorker_DoWork;
                    CalculateHashBackgroundWorker.RunWorkerCompleted += CalculateHashBackgroundWorker_RunWorkerCompleted;

                    UploadBackgroundWorker = new System.ComponentModel.BackgroundWorker();
                    UploadBackgroundWorker.DoWork += UploadBackgroundWorker_DoWork;
                    UploadBackgroundWorker.RunWorkerCompleted += UploadBackgroundWorker_RunWorkerCompleted;

                    LabelAction.Text = "Aguardando";
                    ProgressBarUpload.Value = 0;
                    LabelBytesTransfered.Text = "0 bytes / 0 bytes";

                    if (MySettings.AWSAccessKeyId != string.Empty)
                    {
                        SprightlySoftAWS.S3.Helper MyHelper = new SprightlySoftAWS.S3.Helper();
                        Dictionary<String, String> ContentTypesDictionary;
                        ContentTypesDictionary = MyHelper.GetContentTypesDictionary();

                        AmazonS3Client client = new AmazonS3Client(MySettings.AWSAccessKeyId, MySettings.AWSSecretAccessKey, RegionEndpoint.SAEast1);
                        try
                        {
                            ListObjectsRequest request = new ListObjectsRequest
                            {
                                BucketName = MySettings.DownloadBucketName,
                                MaxKeys = 10
                            };
                            ListObjectsResponse response;
                            do
                            {
                                response = client.ListObjects(request);
                                // Process response.
                                int i = 1;
                                foreach (S3Object entry in response.S3Objects)
                                {
                                    DataRow dr2;
                                    dr2 = dsArquivo.Tables[0].Select("nome ='" + entry.Key + "'").FirstOrDefault();
                                    if (dr2 == null)
                                    {
                                        dr2 = dsArquivo.Tables[0].NewRow();
                                        dr2["id_arquivo"] = i;
                                        dr2["selecionado"] = 0;
                                        dr2["nome"] = entry.Key;
                                        dr2["id_plano"] = 0;
                                        dr2["tamanho"] = TamanhoAmigavel(entry.Size);
                                        String MyExtension;
                                        MyExtension = System.IO.Path.GetExtension(txtUploadKeyName.Text);
                                        MyExtension = MyExtension.ToLower();

                                        if (ContentTypesDictionary.ContainsKey(MyExtension) == true)
                                        {
                                            dr2["content_type"] = ContentTypesDictionary[MyExtension];
                                        }

                                        dsArquivo.Tables[0].Rows.Add(dr2);
                                        i++;
                                    }
                                }

                            } while (response.IsTruncated == true);

                            dgvArquivo.Refresh();

                        }
                        catch (AmazonS3Exception amazonS3Exception)
                        {
                            MessageBox.Show("Erro:" + amazonS3Exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }

            timer1.Enabled = true;

        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            MySettings.AWSAccessKeyId = txtAWSAccessKeyId.Text;
            MySettings.AWSSecretAccessKey = txtAWSSecretAccessKey.Text;
            MySettings.usuario = txtUsuario.Text;
            MySettings.senha = txtSenha.Text;
            MySettings.caminho = txtCaminho.Text;
            MySettings.caminho_backup = txtCaminhoBackup.Text;
            MySettings.PortaBanco = txtPortaServidor.Text;

            MySettings.DownloadBucketName = txtDownloadBucketName.Text;
            MySettings.DownloadKeyName = txtDownloadKeyName.Text;
            MySettings.DownloadFileName = txtDownloadFileName.Text;

            MySettings.UploadFileName = txtUploadFileName.Text;
            MySettings.UploadBucketName = txtUploadBucketName.Text;
            MySettings.UploadKeyName = txtUploadKeyName.Text;
            MySettings.UploadContentType = txtUploadContentType.Text;
            MySettings.UploadMakePublic = CheckBoxUploadMakePublic.Checked;

            MySettings.smtp = txtSMTP.Text;
            MySettings.porta = txtPorta.Text;
            MySettings.email_e = txtEmailEmitente.Text;
            MySettings.senha_e = txtSenhaEmitente.Text;
            MySettings.email_d = txtEmailDestinatario.Text;
            MySettings.conta_email = txtContaEmail.Text;
            MySettings.servidor_banco = txtServidor.Text;
            MySettings.gfix = txtGfix.Text;
            MySettings.tempo_espera = txtTempoEspera.Text;

            MySettings.Save();
            if (dsAgenda.Tables[0].Rows.Count > 0)
            {
                dsAgenda.Tables[0].WriteXml("agenda.xml");
            }
            if (dsArquivo.Tables[0].Rows.Count > 0)
            {
                dsArquivo.Tables[0].WriteXml("arquivo.xml");
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            foreach (DataRow dataRow in dsAgenda.Tables["agenda"].Rows)
            {
                if (dataRow["check"].ToString() == "1")
                {
                    Backup(Convert.ToInt32(dataRow["id"]));
                }
            }
        }

        public void Backup(Int32 v_IdPlano)
        {
            txtLog.Text = string.Empty;
            txtLog.Update();

            DataRow dr2;
            dr2 = dsAgenda.Tables[0].Select("id =" + v_IdPlano.ToString()).FirstOrDefault();
            string v_Destino = dr2["destino"].ToString();
            string v_Origem = dr2["origem"].ToString();
            string ext = Path.GetExtension(v_Origem);
            string v_NewOrig = System.IO.Path.GetDirectoryName(v_Origem) + "\\" + "backup_" + v_IdPlano.ToString() + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ext;
            v_First = true;

            FbConfiguration configuration = new FbConfiguration();

            FbConnectionStringBuilder cs = new FbConnectionStringBuilder();
            cs.Port = Convert.ToInt32(Properties.Settings.Default.PortaBanco);
            cs.UserID = Properties.Settings.Default.usuario;
            cs.Password = Properties.Settings.Default.senha;
            cs.Database = txtServidor.Text + ":" + v_Origem;
            if (txtTempoEspera.Text == string.Empty)
                txtTempoEspera.Text = "2";

            notifyIcon1.ShowBalloonTip(1000, "AWS Backup", "Backup Iniciado: " + DateTime.Now.ToString(), ToolTipIcon.Info);

            txtLog.AppendText("Backup Iniciado: " + DateTime.Now.ToString() + Environment.NewLine);
            try
            {
                txtLog.AppendText("Enviando comando MasterNFE: " + DateTime.Now.ToString() + Environment.NewLine);

                using (var connection = new FbConnection(cs.ToString()))
                {
                    connection.Open();
                    string comando = "insert into movimentom_nfe(id_nfe,id_movimento,id_empresa,ambiente,tipoenv,envio,data_envio,status,modelo) ";
                    comando += "select distinct 0,0,id_empresa,1,'BKP','"+txtTempoEspera.Text+"'," +
                        "'" +DateTime.Now.Day.ToString() + "." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString() + ":" + DateTime.Now.ToLongTimeString() + "','E',sintegramodelo from serie where tipolayout in ('E', 'S'); ";

                    FbCommand fbCom = new FbCommand(comando, connection);
                    fbCom.ExecuteNonQuery();
                    connection.Close();
                    FbConnection.ClearPool(connection);
                }

                /*txtLog.AppendText("Aguardando encerramento MasterNFE: " + DateTime.Now.ToString() + Environment.NewLine);
                configuration.ConnectionString = cs.ToString();
                configuration.DatabaseShutdown(FbShutdownMode.Forced, 60); // wait five  seconds before shutdown

                configuration.DatabaseOnline();*/
                Thread.Sleep(120000);


                txtLog.AppendText("Alterando nome do arquivo da base de dados: " + DateTime.Now.ToString() + Environment.NewLine);
                File.Move(v_Origem, v_NewOrig);
                v_Origem = v_NewOrig;
                v_Origem = v_NewOrig;

                if (txtGfix.Text != string.Empty)
                {
                    txtLog.AppendText("Verificando base de dados: " + DateTime.Now.ToString() + Environment.NewLine);

                    Process p1 = new Process();
                    p1.StartInfo.FileName = txtGfix.Text;
                    p1.StartInfo.Arguments = " -v -f " + txtServidor.Text + ":" + v_Origem + " -user " + Properties.Settings.Default.usuario + " -pass " + Properties.Settings.Default.senha;
                    p1.StartInfo.CreateNoWindow = false;
                    p1.Start();
                    p1.WaitForExit();

                    txtLog.AppendText("Corrigindo base de dados: " + DateTime.Now.ToString() + Environment.NewLine);

                    Process p2 = new Process();
                    p2.StartInfo.FileName = txtGfix.Text;
                    p2.StartInfo.Arguments = " -m -i " + txtServidor.Text + ":" + v_Origem + " -user " + Properties.Settings.Default.usuario + " -pass " + Properties.Settings.Default.senha ;
                    p2.StartInfo.CreateNoWindow = false;
                    p2.Start();
                    p2.WaitForExit();

                }

                cs.Clear();
                cs.Port = Convert.ToInt32(Properties.Settings.Default.PortaBanco);
                cs.UserID = Properties.Settings.Default.usuario;
                cs.Password = Properties.Settings.Default.senha;
                cs.Database = txtServidor.Text + ":" + v_Origem;

                FbBackup backupSvc = new FbBackup();

                backupSvc.ConnectionString = cs.ToString();
                backupSvc.BackupFiles.Add(new FbBackupFile(v_Destino, 4096));
                backupSvc.Verbose = true;                

                string[] opcs = Regex.Split(dr2["opcoes"].ToString(), ";");
                if (opcs[0] != string.Empty)
                    foreach (string op in opcs)
                    {
                        if (op == "1")
                            backupSvc.Options = FbBackupFlags.OldDescriptions;
                        if (op == "2")
                            backupSvc.Options = FbBackupFlags.NonTransportable;
                        if (op == "3")
                            backupSvc.Options = FbBackupFlags.NoGarbageCollect;
                        if (op == "4")
                           backupSvc.Options = FbBackupFlags.NoDatabaseTriggers;
                        if (op == "5")
                            backupSvc.Options = FbBackupFlags.MetaDataOnly;
                        if (op == "6;")
                            backupSvc.Options = FbBackupFlags.IgnoreChecksums;
                        if (op == "7;")
                            backupSvc.Options = FbBackupFlags.Expand;
                        if (op == "8")
                            backupSvc.Options = FbBackupFlags.Convert;
                        if (op == "9")
                            backupSvc.Options = FbBackupFlags.IgnoreLimbo;
                    }


                backupSvc.ServiceOutput += new System.EventHandler<ServiceOutputEventArgs>(ServiceOutput);

                backupSvc.Execute();

                txtUploadFileName.Text = string.Empty;

                List<string> arquivos = new List<string>();
                string v_Arquivo = dr2["diretorio_backup"].ToString() + "\\" + "backup_" + v_IdPlano.ToString() + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".zip";

                arquivos.Add(v_Destino);
                txtUploadKeyName.Text = string.Empty;
                txtUploadKeyName.Text = v_Arquivo;
                txtUploadFileName.Text = string.Empty;
                txtUploadFileName.Text = v_Arquivo;

                txtLog.AppendText("Compactando arquivo: " + DateTime.Now.ToString() + Environment.NewLine);

                CriarArquivoZip(arquivos, v_Arquivo);

                SprightlySoftAWS.S3.Helper MyHelper = new SprightlySoftAWS.S3.Helper();
                Dictionary<String, String> ContentTypesDictionary;
                ContentTypesDictionary = MyHelper.GetContentTypesDictionary();

                String MyExtension;
                MyExtension = System.IO.Path.GetExtension(txtUploadKeyName.Text);
                MyExtension = MyExtension.ToLower();

                if (ContentTypesDictionary.ContainsKey(MyExtension) == true)
                {
                    txtUploadContentType.Text = ContentTypesDictionary[MyExtension];
                }
                else
                {
                    txtUploadContentType.Text = "";
                }

                FileInfo fileInfo = new FileInfo(v_Arquivo);
                DataRow dr3;
                dr3 = dsArquivo.Tables[0].NewRow();
                dr3["selecionado"] = 0;
                dr3["nome"] = v_Arquivo;
                dr3["id_plano"] = v_IdPlano;
                dr3["tamanho"] = TamanhoAmigavel(fileInfo.Length);
                dr3["content_type"] = txtUploadContentType.Text;

                dsArquivo.Tables[0].Rows.Add(dr3);
                dgvArquivo.Refresh();

                if (dr2["amazon"].ToString() == "1")
                {
                    txtLog.AppendText("Upload para servidor Amazon: " + DateTime.Now.ToString() + Environment.NewLine);
                    UploadAmazon(v_Arquivo);
                }

                txtLog.AppendText("Alterando nome do arquivo da base de dados: " + DateTime.Now.ToString() + Environment.NewLine);
                File.Move(v_Origem, dr2["origem"].ToString());

                txtLog.AppendText("Restore da Base: " + DateTime.Now.ToString() + Environment.NewLine);
                Restore(dr2["destino"].ToString(), dr2["origem"].ToString());

                txtLog.AppendText("Apagando Backup: " + DateTime.Now.ToString() + Environment.NewLine);
                File.Delete(v_Destino);

                txtLog.AppendText("Backup Finalizado: " + DateTime.Now.ToString() + Environment.NewLine);
                v_First = false;

                notifyIcon1.ShowBalloonTip(1000, "AWS Backup", "Backup Finalizado: " + DateTime.Now.ToString(), ToolTipIcon.Info);

            }
            catch (Exception ex)
            {
                File.Move(v_Origem, dr2["origem"].ToString());
                string v_Empresa = string.Empty;
                using (var connection = new FbConnection(cs.ToString()))
                {
                    connection.Open();
                    string comando = "select first 1 descricao from empresa ";
                    FbCommand fbCom = new FbCommand(comando, connection);
                    using (IDataReader dr = fbCom.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            v_Empresa = dr.GetString(0);

                        }
                    }
                    connection.Close();
                    FbConnection.ClearPool(connection);
                }

                Properties.Settings MySettings = new Properties.Settings();
                txtSMTP.Text = MySettings.smtp;
                txtPorta.Text = MySettings.porta;
                txtEmailEmitente.Text = MySettings.email_e;
                txtSenhaEmitente.Text = MySettings.senha_e;
                txtEmailDestinatario.Text = MySettings.email_d;

                txtLog.AppendText("Erro Backup: " + DateTime.Now.ToString() + ":" + ex.Message.ToString() + Environment.NewLine);
                EnviaMensagemEmail(txtEmailDestinatario.Text, txtEmailEmitente.Text, "Erro Backup: " + DateTime.Now.ToString() +" - "+v_Empresa, ex.Message.ToString() + Environment.NewLine + txtLog.Text, null);
            }

        }

        static void ServiceOutput(object sender, ServiceOutputEventArgs e)
        {
            txtLog.AppendText(e.Message + Environment.NewLine);
        }

        public void Restore(string v_arquivo_gbk, string v_arquivo_base)
        {
            try
            {
                FbConnectionStringBuilder cs = new FbConnectionStringBuilder();

                cs.UserID = Properties.Settings.Default.usuario;
                cs.Password = Properties.Settings.Default.senha;
                cs.Database = v_arquivo_base;

                FbRestore restoreSvc = new FbRestore();

                restoreSvc.ConnectionString = cs.ToString();
                restoreSvc.BackupFiles.Add(new FbBackupFile(v_arquivo_gbk, 2048));
                restoreSvc.Verbose = true;
                restoreSvc.PageSize = 4096;
                restoreSvc.Options = FbRestoreFlags.Create | FbRestoreFlags.Replace;

                restoreSvc.ServiceOutput += new System.EventHandler<ServiceOutputEventArgs>(ServiceOutput);

                restoreSvc.Execute();
            }
            catch (Exception ex)
            {
                txtSMTP.Text = MySettings.smtp;
                txtPorta.Text = MySettings.porta;
                txtEmailEmitente.Text = MySettings.email_e;
                txtSenhaEmitente.Text = MySettings.senha_e;
                txtEmailDestinatario.Text = MySettings.email_d;
                txtContaEmail.Text = MySettings.conta_email;

                txtLog.AppendText("Erro Restore: " + DateTime.Now.ToString() + ":" + ex.Message.ToString() + Environment.NewLine);

                EnviaMensagemEmail(txtEmailDestinatario.Text, txtEmailEmitente.Text, "Erro Restore: " + DateTime.Now.ToString(), ex.Message.ToString() + Environment.NewLine + txtLog.Text, null);
            }


        }


        public void EnviaMensagemEmail(string Destinatario, string Remetente, string Assunto, string enviaMensagem, ArrayList anexos)
        {

            string nomeRemetente = "MasterCim";
            string emailRemetente = txtEmailEmitente.Text;
            string senha = txtSenhaEmitente.Text;

            //Host da porta SMTP
            string SMTP = txtSMTP.Text;

            string emailDestinatario = txtEmailDestinatario.Text;
            //string emailComCopia        = "email@comcopia.com.br";
            //string emailComCopiaOculta  = "email@comcopiaoculta.com.br";

            string assuntoMensagem = Assunto;
            string conteudoMensagem = enviaMensagem;

            //Cria objeto com dados do e-mail.
            MailMessage objEmail = new MailMessage();

            //Define o Campo From e ReplyTo do e-mail.
            objEmail.From = new System.Net.Mail.MailAddress(nomeRemetente + "<" + emailRemetente + ">");

            //Define os destinatários do e-mail.
            objEmail.To.Add(emailDestinatario);

            //Enviar cópia para.
            //objEmail.CC.Add(emailComCopia);

            //Enviar cópia oculta para.
            //objEmail.Bcc.Add(emailComCopiaOculta);

            //Define a prioridade do e-mail.
            objEmail.Priority = System.Net.Mail.MailPriority.Normal;

            //Define o formato do e-mail HTML (caso não queira HTML alocar valor false)
            objEmail.IsBodyHtml = true;

            //Define título do e-mail.
            objEmail.Subject = assuntoMensagem;

            //Define o corpo do e-mail.
            objEmail.Body = conteudoMensagem;


            //Para evitar problemas de caracteres "estranhos", configuramos o charset para "ISO-8859-1"
            objEmail.SubjectEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
            objEmail.BodyEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");


            // Caso queira enviar um arquivo anexo
            //Caminho do arquivo a ser enviado como anexo
            //string arquivo = Server.MapPath("arquivo.jpg");

            // Ou especifique o caminho manualmente
            //string arquivo = @"e:\home\LoginFTP\Web\arquivo.jpg";

            // Cria o anexo para o e-mail
            //Attachment anexo = new Attachment(arquivo, System.Net.Mime.MediaTypeNames.Application.Octet);

            // Anexa o arquivo a mensagem
            //objEmail.Attachments.Add(anexo);

            //Cria objeto com os dados do SMTP
            System.Net.Mail.SmtpClient objSmtp = new System.Net.Mail.SmtpClient();

            //Alocamos o endereço do host para enviar os e-mails  
            objSmtp.Credentials = new System.Net.NetworkCredential(txtContaEmail.Text, senha);
            objSmtp.Host = SMTP;
            objSmtp.Port = Convert.ToInt32(txtPorta.Text);
            //Caso utilize conta de email do exchange da locaweb deve habilitar o SSL
            //objEmail.EnableSsl = true;

            //Enviamos o e-mail através do método .send()
            try
            {
                objSmtp.Send(objEmail);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                //excluímos o objeto de e-mail da memória
                objEmail.Dispose();
                //anexo.Dispose();
            }
        }

        public static void CriarArquivoZip(List<string> arquivos, string ArquivoDestino)
        {
            using (ZipFile zip = new ZipFile())
            {
                // percorre todos os arquivos da lista
                foreach (string item in arquivos)
                {
                    // se o item é um arquivo
                    if (File.Exists(item))
                    {
                        try
                        {
                            // Adiciona o arquivo na pasta raiz dentro do arquivo zip
                            zip.AddFile(item, "");
                        }
                        catch
                        {
                            throw;
                        }
                    }
                    // se o item é uma pasta
                    else if (Directory.Exists(item))
                    {
                        try
                        {
                            // Adiciona a pasta no arquivo zip com o nome da pasta 
                            zip.AddDirectory(item, new DirectoryInfo(item).Name);
                        }
                        catch
                        {
                            throw;
                        }
                    }
                }
                // Salva o arquivo zip para o destino
                try
                {
                    zip.Save(ArquivoDestino);
                }
                catch
                {
                    throw;
                }
            }
        }

        public static void ExtrairArquivoZip(string localizacaoArquivoZip, string destino)
        {
            if (File.Exists(localizacaoArquivoZip))
            {
                //recebe a localização do arquivo zip
                using (ZipFile zip = new ZipFile(localizacaoArquivoZip))
                {
                    //verifica se o destino existe
                    if (Directory.Exists(destino))
                    {
                        try
                        {
                            //extrai o arquivo zip para o destino
                            zip.ExtractAll(destino);
                        }
                        catch
                        {
                            throw;
                        }
                    }
                    else
                    {
                        //lança uma exceção se o destino não existe
                        throw new DirectoryNotFoundException("O arquivo destino não foi localizado");
                    }
                }
            }
            else
            {
                //lança uma exceção se a origem não existe
                throw new FileNotFoundException("O Arquivo Zip não foi localizado");
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            foreach (DataRow dataRow in dsAgenda.Tables["agenda"].Rows)
            {
                if (dataRow["check"].ToString() == "1")
                {
                    Restore(dataRow["destino"].ToString(), dataRow["origem"].ToString());
                }
            }
         
        }

        private void ButtonUploadFile_Click(object sender, EventArgs e)
        {
            EnableDisableStartUpload();

            if (System.IO.File.Exists(txtUploadFileName.Text) == true)
            {
                //Start by calculating the MD5 hash of the file.  This will be sent to Amazon in the 
                //upload to make sure it arrives correctly.
                LabelAction.Text = "Calculando MD5 hash";
                Application.DoEvents();

                //Run the hash calculation in a BackgroundWorker process.  Calculating the hash of a
                //large file will take a while.  Running the process in a BackgroundWorker will prevent
                //the form from locking up.

                //Use a hash table to pass parameters to the function in the BackgroundWorker.
                System.Collections.Hashtable CalculateHashHashTable = new System.Collections.Hashtable();
                CalculateHashHashTable.Add("LocalFileName", txtUploadFileName.Text);

                CalculateHashBackgroundWorker.RunWorkerAsync(CalculateHashHashTable);
            }
            else
            {
                EnableDisableEndUpload();
                MessageBox.Show("Arquivo no diretorio local não existe.", "Erro ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ButtonDownloadFile_Click(object sender, EventArgs e)
        {
            EnableDisableStartDownload();

            if (txtDownloadFileName.Text.Contains("\\") == true && System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(txtDownloadFileName.Text)) == true)
            {
                Properties.Settings MySettings = new Properties.Settings();

                String RequestURL;
                RequestURL = MyDownload.BuildS3RequestURL(true, "s3.amazonaws.com", txtDownloadBucketName.Text, txtDownloadKeyName.Text, "");

                String RequestMethod = "GET";

                Dictionary<String, String> ExtraRequestHeaders = new Dictionary<String, String>();
                ExtraRequestHeaders.Add("x-amz-date", DateTime.UtcNow.ToString("r"));

                String AuthorizationValue;
                AuthorizationValue = MyDownload.GetS3AuthorizationValue(RequestURL, RequestMethod, ExtraRequestHeaders, MySettings.AWSAccessKeyId, MySettings.AWSSecretAccessKey);
                ExtraRequestHeaders.Add("Authorization", AuthorizationValue);

                //Use a hash table to pass parameters to the function in the BackgroundWorker.
                System.Collections.Hashtable DownloadHashTable = new System.Collections.Hashtable();
                DownloadHashTable.Add("RequestURL", RequestURL);
                DownloadHashTable.Add("RequestMethod", RequestMethod);
                DownloadHashTable.Add("ExtraRequestHeaders", ExtraRequestHeaders);
                DownloadHashTable.Add("LocalFileName", txtDownloadFileName.Text);


                //Run the DownloadFile function in a BackgroundWorker process.  Downloading a large
                //file may take a long time.  Running the process in a BackgroundWorker will prevent
                //the Window from locking up.
                DownloadBackgroundWorker.RunWorkerAsync(DownloadHashTable);
            }
            else
            {
                EnableDisableEndDownload();
                MessageBox.Show("Arquivo no diretorio local não existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void EnableDisableStartDownload()
        {
            txtDownloadBucketName.Enabled = false;
            txtDownloadKeyName.Enabled = false;
            txtDownloadFileName.Enabled = false;
            ButtonDownloadFile.Enabled = false;

            ButtonAbort.Enabled = true;
            ProgressBarDownload.Enabled = true;
            LabelBytesTransfered.Enabled = true;

            ProgressBarDownload.Value = 0;
            LabelBytesTransfered.Text = "0 bytes / 0 bytes";
        }

        private void EnableDisableEndDownload()
        {
            txtDownloadBucketName.Enabled = true;
            txtDownloadKeyName.Enabled = true;
            txtDownloadFileName.Enabled = true;
            ButtonDownloadFile.Enabled = true;

            ButtonAbort.Enabled = false;
            ProgressBarDownload.Enabled = false;
            LabelBytesTransfered.Enabled = false;

            ProgressBarDownload.Value = 0;
            LabelBytesTransfered.Text = "0 bytes / 0 bytes";
        }

        private void DownloadBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            System.Collections.Hashtable DownloadHashTable = e.Argument as System.Collections.Hashtable;

            //Call the DownloadFile function and set the result.  When the function is complete
            //the RunWorkerCompleted event will fire.  Use the parameters that were passed in the 
            //hash table.
            e.Result = MyDownload.DownloadFile(DownloadHashTable["RequestURL"].ToString(), DownloadHashTable["RequestMethod"].ToString(), DownloadHashTable["ExtraRequestHeaders"] as Dictionary<String, String>, DownloadHashTable["LocalFileName"].ToString(), false);
        }


        private void DownloadBackgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            System.Diagnostics.Debug.Print("");
            System.Diagnostics.Debug.Print(MyDownload.LogData);
            System.Diagnostics.Debug.Print("");

            EnableDisableEndDownload();

            if (Convert.ToBoolean(e.Result) == true)
            {
                MessageBox.Show("Download completo.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Delete a partially downloaded file
                if (System.IO.File.Exists(txtDownloadFileName.Text) == true)
                {
                    System.IO.File.Delete(txtDownloadFileName.Text);
                }

                //Show the error message.
                String ResponseMessage;

                if (MyDownload.ResponseString == "")
                {
                    ResponseMessage = MyDownload.ErrorDescription;
                }
                else
                {
                    System.Xml.XmlDocument XmlDoc = new System.Xml.XmlDocument();
                    XmlDoc.LoadXml(MyDownload.ResponseString);

                    System.Xml.XmlNode XmlNode;
                    XmlNode = XmlDoc.SelectSingleNode("/Error/Message");

                    ResponseMessage = XmlNode.InnerText;
                }

                MessageBox.Show(ResponseMessage, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MyDownload_ProgressChangedEvent()
        {
            if (this.InvokeRequired == true)
            {
                this.BeginInvoke(new MethodInvoker(delegate () { MyDownload_ProgressChangedEvent(); }));
            }
            else
            {
                //Set the progress bar when the ProgressChangedEvent is fired.
                if (MyDownload.BytesTotal > 0)
                {
                    decimal MyDecimal = (Convert.ToDecimal(MyDownload.BytesTransfered) / Convert.ToDecimal(MyDownload.BytesTotal)) * 100;
                    ProgressBarDownload.Value = Convert.ToInt32(MyDecimal);

                    SprightlySoftAWS.S3.Helper MyHelper = new SprightlySoftAWS.S3.Helper();
                    LabelBytesTransfered.Text = MyHelper.FormatByteSize(MyDownload.BytesTransfered) + " / " + MyHelper.FormatByteSize(MyDownload.BytesTotal);
                }
            }
        }

        private void EnableDisableStartUpload()
        {
            txtUploadFileName.Enabled = false;
            txtUploadBucketName.Enabled = false;
            txtUploadKeyName.Enabled = false;
            txtUploadContentType.Enabled = false;
            CheckBoxUploadMakePublic.Enabled = false;
            ButtonUploadBrowse.Enabled = false;
            ButtonUploadFile.Enabled = false;

            ButtonAbort.Enabled = true;
            LabelAction.Enabled = true;
            ProgressBarUpload.Enabled = true;
            LabelBytesTransfered.Enabled = true;

            LabelAction.Text = "Aguardando";
            ProgressBarUpload.Value = 0;
            LabelBytesTransfered.Text = "0 bytes / 0 bytes";
        }

        private void EnableDisableEndUpload()
        {
            txtUploadFileName.Enabled = true;
            txtUploadBucketName.Enabled = true;
            txtUploadKeyName.Enabled = true;
            txtUploadContentType.Enabled = true;
            CheckBoxUploadMakePublic.Enabled = true;
            ButtonUploadBrowse.Enabled = true;
            ButtonUploadFile.Enabled = true;

            ButtonAbort.Enabled = false;
            LabelAction.Enabled = false;
            ProgressBarUpload.Enabled = false;
            LabelBytesTransfered.Enabled = false;

            LabelAction.Text = "Aguardando";
            ProgressBarUpload.Value = 0;
            LabelBytesTransfered.Text = "0 bytes / 0 bytes";
        }

        private void MyCalculateHash_ProgressChangedEvent()
        {
            if (this.InvokeRequired == true)
            {
                this.BeginInvoke(new MethodInvoker(delegate () { MyCalculateHash_ProgressChangedEvent(); }));
            }
            else
            {
                //Update the progress bar when the ProgressChangedEvent is fired.
                if (MyCalculateHash.BytesTotal > 0)
                {
                    decimal MyDecimal = (Convert.ToDecimal(MyCalculateHash.BytesProcessed) / Convert.ToDecimal(MyCalculateHash.BytesTotal)) * 100;
                    ProgressBarUpload.Value = Convert.ToInt32(MyDecimal);

                    SprightlySoftAWS.S3.Helper MyHelper = new SprightlySoftAWS.S3.Helper();
                    LabelBytesTransfered.Text = MyHelper.FormatByteSize(MyCalculateHash.BytesProcessed) + " / " + MyHelper.FormatByteSize(MyCalculateHash.BytesTotal);
                }
            }
        }

        private void MyUpload_ProgressChangedEvent()
        {
            if (this.InvokeRequired == true)
            {
                this.BeginInvoke(new MethodInvoker(delegate () { MyUpload_ProgressChangedEvent(); }));
            }
            else
            {
                //Update the progress bar when the ProgressChangedEvent is fired.
                if (MyUpload.BytesTotal > 0)
                {
                    decimal MyDecimal = (Convert.ToDecimal(MyUpload.BytesTransfered) / Convert.ToDecimal(MyUpload.BytesTotal)) * 100;
                    ProgressBarUpload.Value = Convert.ToInt32(MyDecimal);

                    SprightlySoftAWS.S3.Helper MyHelper = new SprightlySoftAWS.S3.Helper();
                    LabelBytesTransfered.Text = MyHelper.FormatByteSize(MyUpload.BytesTransfered) + " / " + MyHelper.FormatByteSize(MyUpload.BytesTotal);
                }
            }
        }

        private void CalculateHashBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //Call the CalculateMD5FromFile function and set the result.  When the function is complete
            //the RunWorkerCompleted event will fire.  Use the LocalFileName value from the passed hash table.
            System.Collections.Hashtable CalculateHashHashTable = e.Argument as System.Collections.Hashtable;
            e.Result = MyCalculateHash.CalculateMD5FromFile(CalculateHashHashTable["LocalFileName"].ToString());
        }

        private void CalculateHashBackgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            //If the CalculateMD5FromFile function was successful upload the file.
            if (MyCalculateHash.ErrorNumber == 0)
            {
                LabelAction.Text = "Upload de Arquivo";
                Application.DoEvents();

                //Set the extra request headers to send with the upload
                Dictionary<String, String> ExtraRequestHeaders = new Dictionary<String, String>();

                if (txtUploadContentType.Text != "")
                {
                    ExtraRequestHeaders.Add("Content-Type", txtUploadContentType.Text);
                }

                if (CheckBoxUploadMakePublic.Checked == true)
                {
                    ExtraRequestHeaders.Add("x-amz-acl", "public-read");
                }

                //Use the MD5 hash that was calculated previously.
                ExtraRequestHeaders.Add("Content-MD5", e.Result.ToString());

                Properties.Settings MySettings = new Properties.Settings();

                String RequestURL;
                RequestURL = MyUpload.BuildS3RequestURL(true, "s3.amazonaws.com", txtUploadBucketName.Text, txtUploadKeyName.Text, "");

                String RequestMethod = "PUT";

                ExtraRequestHeaders.Add("x-amz-date", DateTime.UtcNow.ToString("r"));

                String AuthorizationValue;
                AuthorizationValue = MyUpload.GetS3AuthorizationValue(RequestURL, RequestMethod, ExtraRequestHeaders, MySettings.AWSAccessKeyId, MySettings.AWSSecretAccessKey);
                ExtraRequestHeaders.Add("Authorization", AuthorizationValue);

                //Create a hash table of of parameters to sent to the upload function.
                System.Collections.Hashtable UploadHashTable = new System.Collections.Hashtable();
                UploadHashTable.Add("RequestURL", RequestURL);
                UploadHashTable.Add("RequestMethod", RequestMethod);
                UploadHashTable.Add("ExtraRequestHeaders", ExtraRequestHeaders);
                UploadHashTable.Add("LocalFileName", txtUploadFileName.Text);

                //Run the UploadFile call in a BackgroundWorker to prevent the Window from freezing.
                UploadBackgroundWorker.RunWorkerAsync(UploadHashTable);
            }
            else
            {
                EnableDisableEndUpload();
                MessageBox.Show(MyCalculateHash.ErrorDescription, "Erro ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UploadBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //Run the UploadFile call.
            System.Collections.Hashtable UploadHashTable = e.Argument as System.Collections.Hashtable;

            e.Result = MyUpload.UploadFile(UploadHashTable["RequestURL"].ToString(), UploadHashTable["RequestMethod"].ToString(), UploadHashTable["ExtraRequestHeaders"] as Dictionary<String, String>, UploadHashTable["LocalFileName"].ToString());
        }

        private void UploadBackgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            System.Diagnostics.Debug.Print("");
            System.Diagnostics.Debug.Print(MyUpload.LogData);
            System.Diagnostics.Debug.Print("");

            EnableDisableEndUpload();

            if (Convert.ToBoolean(e.Result) == true)
            {
                //MessageBox.Show("Upload completo.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Show the error message.
                String ResponseMessage;

                if (MyUpload.ResponseString == "")
                {
                    ResponseMessage = MyUpload.ErrorDescription;
                }
                else
                {
                    System.Xml.XmlDocument XmlDoc = new System.Xml.XmlDocument();
                    XmlDoc.LoadXml(MyUpload.ResponseString);

                    System.Xml.XmlNode XmlNode;
                    XmlNode = XmlDoc.SelectSingleNode("/Error/Message");

                    ResponseMessage = XmlNode.InnerText;
                }

                MessageBox.Show(ResponseMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonUploadBrowse_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            OpenFileDialog.Multiselect = false;
            OpenFileDialog.FileName = "";
            OpenFileDialog.ShowDialog();

            if (OpenFileDialog.FileName != "" && System.IO.File.Exists(OpenFileDialog.FileName) == true)
            {
                txtUploadFileName.Text = OpenFileDialog.FileName;
                txtUploadKeyName.Text = System.IO.Path.GetFileName(OpenFileDialog.FileName);

                //set the content type from the file's extension
                //the SprightlySoftS3 Helper class contains a function that returns a dictionary of extensions and associated content types
                SprightlySoftAWS.S3.Helper MyHelper = new SprightlySoftAWS.S3.Helper();
                Dictionary<String, String> ContentTypesDictionary;
                ContentTypesDictionary = MyHelper.GetContentTypesDictionary();

                String MyExtension;
                MyExtension = System.IO.Path.GetExtension(OpenFileDialog.FileName);
                MyExtension = MyExtension.ToLower();

                if (ContentTypesDictionary.ContainsKey(MyExtension) == true)
                {
                    txtUploadContentType.Text = ContentTypesDictionary[MyExtension];
                }
                else
                {
                    txtUploadContentType.Text = "";
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Abort the CalculateHash call or Upload call depending on what is taking place.
            if (MyCalculateHash.State == 1)
            {
                MyCalculateHash.Abort();
            }
            else if (MyUpload.State == 1)
            {
                MyUpload.Abort();
            }

        }

        private void TcPrincipal_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowseBanco_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            OpenFileDialog.Multiselect = false;
            OpenFileDialog.FileName = "";
            OpenFileDialog.ShowDialog();

            if (OpenFileDialog.FileName != "" && System.IO.File.Exists(OpenFileDialog.FileName) == true)
            {
                txtCaminho.Text = OpenFileDialog.FileName;
                txtCaminhoBackup.Text = OpenFileDialog.InitialDirectory;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DataRow dr2;
            string v_Opcao = string.Empty;
            if (cbOldDescription.Checked)
                v_Opcao += "1;";
            if (cbNoTransportable.Checked)
                v_Opcao += "2;";
            if (cbNoGarbageCollect.Checked)
                v_Opcao += "3;";
            if (cbNoDatabaseTrigger.Checked)
                v_Opcao += "4;";
            if (cbMetaDataOnly.Checked)
                v_Opcao += "5;";
            if (cbIgnoreChecksum.Checked)
                v_Opcao += "6;";
            if (cbExpand.Checked)
                v_Opcao += "7;";
            if (cbConvert.Checked)
                v_Opcao += "8;";
            if (cbIgnoreLimbo.Checked)
                v_Opcao += "9;";

            if (txtId.Text == string.Empty)
            {
                dr2 = dsAgenda.Tables[0].NewRow();
                dr2["origem"] = txtCaminho.Text;
                dr2["destino"] = txtCaminhoBackup.Text;
                dr2["opcoes"] = v_Opcao;
                dr2["plano"] = txtPlano.Text;
                dr2["hora"] = dtpHoraBackup.Text;
                dr2["diabackup"] = SelDias(clbDias);
                dr2["numerobackup"] = txtNumBackup.Text;
                dr2["amazon"] = cbAmazon.Checked;
                dr2["ativo"] = cbAtivo.Checked;
                dr2["diretorio_backup"] = txtDiretorioBackup.Text;

                dsAgenda.Tables[0].Rows.Add(dr2);
                cbAtivo.Checked = true;
            }
            else
            {
                dr2 = dsAgenda.Tables[0].Select("id =" + txtId.Text).FirstOrDefault();
                if (dr2 != null)
                {
                    dr2["id"] = txtId.Text;
                    dr2["origem"] = txtCaminho.Text;
                    dr2["destino"] = txtCaminhoBackup.Text;
                    dr2["opcoes"] = v_Opcao;
                    dr2["plano"] = txtPlano.Text;
                    dr2["hora"] = dtpHoraBackup.Text;
                    dr2["diabackup"] = SelDias(clbDias);
                    dr2["numerobackup"] = txtNumBackup.Text;
                    dr2["amazon"] = cbAmazon.Checked;
                    dr2["ativo"] = cbAtivo.Checked;
                    dr2["diretorio_backup"] = txtDiretorioBackup.Text;
                    dsAgenda.Tables[0].AcceptChanges();
                }
            }

            dgvAgenda.Refresh();
            timer1.Enabled = true;
            Limpar();   
        }

        private void dgvAgenda_DoubleClick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            int i;
            i = dgvAgenda.SelectedCells[0].RowIndex;

            txtId.Text = dgvAgenda.Rows[i].Cells[1].Value.ToString();
            txtPlano.Text = dgvAgenda.Rows[i].Cells[2].Value.ToString();
            txtCaminho.Text = dgvAgenda.Rows[i].Cells[5].Value.ToString();
            txtCaminhoBackup.Text = dgvAgenda.Rows[i].Cells[6].Value.ToString();
            dtpHoraBackup.Value = Convert.ToDateTime(dgvAgenda.Rows[i].Cells[8].Value.ToString());
            txtNumBackup.Text = dgvAgenda.Rows[i].Cells[10].Value.ToString();
            txtDiretorioBackup.Text = dgvAgenda.Rows[i].Cells[11].Value.ToString();

            string[] lines = Regex.Split(dgvAgenda.Rows[i].Cells[9].Value.ToString(), ";");
            if (lines[0] != string.Empty)
                foreach (string line in lines)
                {
                    switch (line)
                    {
                        case "segunda-feira":
                            clbDias.SetItemChecked(0, true);
                            break;
                        case "terça-feira":
                            clbDias.SetItemChecked(1, true);
                            break;
                        case "quarta-feira":
                            clbDias.SetItemChecked(2, true);
                            break;
                        case "quinta-feira":
                            clbDias.SetItemChecked(3, true);
                            break;
                        case "sexta-feira":
                            clbDias.SetItemChecked(4, true);
                            break;
                        case "sabado":
                            clbDias.SetItemChecked(5, true);
                            break;
                        case "domingo":
                            clbDias.SetItemChecked(6, true);
                            break;

                    }
                }

            string[] opcs = Regex.Split(dgvAgenda.Rows[i].Cells[7].Value.ToString(), ";");
            if (opcs[0] != string.Empty)
                foreach (string op in opcs)
                {
                    if (op == "1")
                        cbOldDescription.Checked = true;
                    if (op == "2")
                        cbNoTransportable.Checked = true;
                    if (op == "3")
                        cbNoGarbageCollect.Checked = true;
                    if (op == "4")
                        cbNoDatabaseTrigger.Checked = true;
                    if (op == "5")
                        cbMetaDataOnly.Checked = true;
                    if (op == "6;")
                        cbIgnoreChecksum.Checked = true;
                    if (op == "7;")
                        cbExpand.Checked = true;
                    if (op == "8")
                        cbConvert.Checked = true;
                    if (op == "9")
                        cbIgnoreLimbo.Checked = true;
                }

            if (dgvAgenda.Rows[i].Cells[4].Value.ToString() == "1")
                cbAmazon.Checked = true;
            else
                cbAmazon.Checked = false;
            if (dgvAgenda.Rows[i].Cells[3].Value.ToString() == "1")
                cbAtivo.Checked = true;
            else
                cbAtivo.Checked = false;

        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            foreach (DataRow dataRow in dsAgenda.Tables[0].Rows)
            {
                if (dataRow["check"].ToString() =="True" )
                {
                    Backup(Convert.ToInt32(dataRow["id"]));
                }
            }
        }

        private void btnExcluirArqAmazon_Click(object sender, EventArgs e)
        {
            AmazonS3Client client = new AmazonS3Client(MySettings.AWSAccessKeyId, MySettings.AWSSecretAccessKey, RegionEndpoint.SAEast1);

            foreach (DataRow dataRow in dsArquivo.Tables[0].Rows)
            {
                if (dataRow["check"].ToString() == "1")
                {
                    client.DeleteObject(new Amazon.S3.Model.DeleteObjectRequest() { BucketName = MySettings.DownloadBucketName, Key = dataRow["nome"].ToString() });
                }
            }

        }

        private void ExcluiBackup(Int32 v_IdPlano)
        {
            DataRow drAg,drDel;
            DataRow[] drAr;
            drAg = dsAgenda.Tables[0].Select("id =" + v_IdPlano.ToString()).FirstOrDefault();
            int vCont = 0;

            drAr = dsArquivo.Tables[0].AsEnumerable()
                .Where(r => r.Field<int>("id_plano") == v_IdPlano)
                .OrderBy(r => r.Field<int>("id_arquivo"))
                .ToArray();

            vCont = drAr.ToList().Count;

            while (vCont > Convert.ToInt32(drAg["numerobackup"]))
            {

                foreach (DataRow row in drAr.ToList())
                {
                    string v_Arquivo = row["nome"].ToString();
                    //v_Arquivo = v_Arquivo.Replace(@"\\", @"\");
                    try
                    {
                        if(File.Exists(v_Arquivo))
                           File.Delete(v_Arquivo);
                    }
                    catch (IOException iox)
                    {
                       MessageBox.Show("Erro:" + iox.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (drAg["amazon"].ToString() != "1")
                    {
                       /* try
                        {
                            AmazonS3Client client = new AmazonS3Client(MySettings.AWSAccessKeyId, MySettings.AWSSecretAccessKey, RegionEndpoint.SAEast1);
                            client.DeleteObject(new Amazon.S3.Model.DeleteObjectRequest()
                            {
                                BucketName = MySettings.DownloadBucketName, Key = row["nome"].ToString() }
                            );

                            dsArquivo.Tables[0].Clear();
                            ListObjectsRequest request = new ListObjectsRequest
                            {
                                BucketName = MySettings.DownloadBucketName,
                                MaxKeys = 10
                            };
                            ListObjectsResponse response;
                            do
                            {
                                response = client.ListObjects(request);
                                foreach (S3Object entry in response.S3Objects)
                                {
                                    dsArquivo.Tables[0].Rows.Add(0, entry.Key, entry.Size);
                                }

                            } while (response.IsTruncated == true);

                            dgvArquivo.DataSource = dsArquivo.Tables[0].DefaultView;

                        }
                        catch (AmazonS3Exception amazonS3Exception)
                        {
                            MessageBox.Show("Erro:" + amazonS3Exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }*/

                    }

                    drDel = dsArquivo.Tables[0].Select("id_plano =" + v_IdPlano.ToString() + " and id_arquivo=" + row["id_arquivo"].ToString()).FirstOrDefault();
                    drDel.Delete();
                    vCont--;
                }
            }
            if (dsArquivo.Tables[0].Rows.Count > 0)
            {
                dsArquivo.Tables[0].WriteXml("arquivo.xml");
            }

        }

        private void UploadAmazon(string arquivo)
        {
            EnableDisableStartUpload();

            if (System.IO.File.Exists(arquivo) == true)
            {
                //Start by calculating the MD5 hash of the file.  This will be sent to Amazon in the 
                //upload to make sure it arrives correctly.
                LabelAction.Text = "Calculando MD5 hash";
                Application.DoEvents();

                //Run the hash calculation in a BackgroundWorker process.  Calculating the hash of a
                //large file will take a while.  Running the process in a BackgroundWorker will prevent
                //the form from locking up.

                //Use a hash table to pass parameters to the function in the BackgroundWorker.
                System.Collections.Hashtable CalculateHashHashTable = new System.Collections.Hashtable();
                CalculateHashHashTable.Add("LocalFileName", arquivo);

                CalculateHashBackgroundWorker.RunWorkerAsync(CalculateHashHashTable);
            }
            else
            {
                EnableDisableEndUpload();
                MessageBox.Show("Arquivo local não existe.", "Erro ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (DataRow dataRow in dsAgenda.Tables[0].Rows)
            {
                if (dataRow["ativo"].ToString() == "1")
                {
                    if (dataRow["diabackup"].ToString().Contains(DateTime.Now.ToString("dddd", new CultureInfo("pt-BR"))))
                    {
                        if (Convert.ToDateTime(dataRow["hora"].ToString()).ToString("HH:mm", new CultureInfo("pt-BR")) == DateTime.Now.ToString("HH:mm", new CultureInfo("pt-BR")))
                        {
                            if(v_First == false)
                            {
                               Backup(Convert.ToInt32(dataRow["id"]));
                               ExcluiBackup(Convert.ToInt32(dataRow["id"]));
                            }
                        }
                    }
                }
            }
        }

        public static string TamanhoAmigavel(long bytes)
        {
            if (bytes < 0) throw new ArgumentException("bytes");

            double humano;
            string sufixo;

            if (bytes >= 1152921504606846976L) // Exabyte (1024^6)
            {
                humano = bytes >> 50;
                sufixo = "EB";
            }
            else if (bytes >= 1125899906842624L) // Petabyte (1024^5)
            {
                humano = bytes >> 40;
                sufixo = "PB";
            }
            else if (bytes >= 1099511627776L) // Terabyte (1024^4)
            {
                humano = bytes >> 30;
                sufixo = "TB";
            }
            else if (bytes >= 1073741824) // Gigabyte (1024^3)
            {
                humano = bytes >> 20;
                sufixo = "GB";
            }
            else if (bytes >= 1048576) // Megabyte (1024^2)
            {
                humano = bytes >> 10;
                sufixo = "MB";
            }
            else if (bytes >= 1024) // Kilobyte (1024^1)
            {
                humano = bytes;
                sufixo = "KB";
            }
            else return bytes.ToString("0 B"); // Byte

            humano /= 1024;
            return humano.ToString("0.## ") + sufixo;
        }


        public string SelDias(CheckedListBox cklb)
        {
            string s = string.Empty;

            foreach (object obj in cklb.CheckedItems)
            {
                s += obj.ToString() + ";";
            }
            return s;

        }

        private void Limpar()
        {
            txtId.Text = string.Empty;
            txtPlano.Text = string.Empty;
            txtCaminho.Text = string.Empty;
            txtCaminhoBackup.Text = string.Empty;
            dtpHoraBackup.Text = string.Empty;
            txtNumBackup.Text = string.Empty;
            txtDiretorioBackup.Text = string.Empty;
            clbDias.SetItemChecked(0, false);
            clbDias.SetItemChecked(1, false);
            clbDias.SetItemChecked(2, false);
            clbDias.SetItemChecked(3, false);
            clbDias.SetItemChecked(4, false);
            clbDias.SetItemChecked(5, false);
            clbDias.SetItemChecked(6, false);
            cbOldDescription.Checked = false;
            cbNoTransportable.Checked = false;
            cbNoGarbageCollect.Checked = false;
            cbNoDatabaseTrigger.Checked = false;
            cbMetaDataOnly.Checked = false;
            cbIgnoreChecksum.Checked = false;
            cbExpand.Checked = false;
            cbConvert.Checked = false;
            cbIgnoreLimbo.Checked = false;
            cbAmazon.Checked = false;
            cbAtivo.Checked = false;
        }

        private void btnGfix_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            OpenFileDialog.Multiselect = false;
            OpenFileDialog.FileName = "";
            OpenFileDialog.ShowDialog();

            if (OpenFileDialog.FileName != "" && System.IO.File.Exists(OpenFileDialog.FileName) == true)
            {
                txtGfix.Text = OpenFileDialog.FileName;
            }

        }

        private void btnMasterNFE_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            OpenFileDialog.Multiselect = false;
            OpenFileDialog.FileName = "";
            OpenFileDialog.ShowDialog();

            if (OpenFileDialog.FileName != "" && System.IO.File.Exists(OpenFileDialog.FileName) == true)
            {
                txtTempoEspera.Text = OpenFileDialog.FileName;
            }

        }

        private void exibirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmPrincipal_Move(object sender, EventArgs e)
        {
            if(this.WindowState==FormWindowState.Minimized)
            {
                this.Hide();
            }
        }

        private void cmsMenu_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
        }

        private void frmPrincipal_Shown(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.Hide();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir?", "Confirmação", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {

               DataRow[] row = dsAgenda.Tables[0].Select("check = 1");
               if (row.Length > 0)
                   dsAgenda.Tables[0].Rows.Remove(row[0]);

               dsAgenda.Tables[0].AcceptChanges();
               dgvAgenda.Refresh();

            }
        }

        private void dgvArquivo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6 && e.RowIndex >= 0)
            {
                string arquivo = dgvArquivo.Rows[e.RowIndex].Cells[2].Value.ToString();
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir?", "Confirmação", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    if(File.Exists(arquivo))
                    {
                        File.Delete(arquivo);
                    }
                    dsArquivo.Tables[0].Rows[e.RowIndex].Delete();
                    dsArquivo.Tables[0].AcceptChanges();
                    dgvArquivo.Refresh(); 

                }

            }

        }
    }
}
