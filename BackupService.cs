using FirebirdSql.Data.Services;
using FirebirdSql.Data.FirebirdClient;
using System.Windows.Forms;

namespace AWSBackup
{
    class BackupService
    {

        public void Backup(string v_arquivo_gbk)
        {

            FbConnectionStringBuilder cs = new FbConnectionStringBuilder();

            cs.UserID = Properties.Settings.Default.usuario;
            cs.Password = Properties.Settings.Default.senha;
            cs.Database = Properties.Settings.Default.caminho;

            FbBackup backupSvc = new FbBackup();

            backupSvc.ConnectionString = cs.ToString();
            backupSvc.BackupFiles.Add(new FbBackupFile(v_arquivo_gbk, 2048));
            backupSvc.Verbose = true;

            backupSvc.Options = FbBackupFlags.IgnoreLimbo;

            backupSvc.ServiceOutput += new System.EventHandler<ServiceOutputEventArgs>(ServiceOutput);

            backupSvc.Execute();
        }

        static void ServiceOutput(object sender, ServiceOutputEventArgs e)
        {
            MessageBox.Show(e.Message, "Firebird", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Restore(string v_arquivo_gbk)
        {
            FbConnectionStringBuilder cs = new FbConnectionStringBuilder();

            cs.UserID = Properties.Settings.Default.usuario;
            cs.Password = Properties.Settings.Default.senha;
            cs.Database = Properties.Settings.Default.caminho;

            FbRestore restoreSvc = new FbRestore();

            restoreSvc.ConnectionString = cs.ToString();
            restoreSvc.BackupFiles.Add(new FbBackupFile(v_arquivo_gbk, 2048));
            restoreSvc.Verbose = true;
            restoreSvc.PageSize = 4096;
            restoreSvc.Options = FbRestoreFlags.Create | FbRestoreFlags.Replace;

            restoreSvc.ServiceOutput += new System.EventHandler<ServiceOutputEventArgs>(ServiceOutput);

            restoreSvc.Execute();

        }

    }
}
