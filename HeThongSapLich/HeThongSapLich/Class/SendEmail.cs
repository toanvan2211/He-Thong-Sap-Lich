using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongSapLich.Class
{
    class SendEmail
    {
        private static SendEmail instance;

        public static SendEmail Instance
        {
            get { if (instance == null) instance = new SendEmail(); return instance; }
            private set { instance = value; }
        }

        private string senderID = "hhtoan567@gmail.com";
        private string senderPassword = "VANcongtoan123";
        public static string NguoiNhan { get; set; }

        public SendEmail() { }

        public void GuiMail(string tieuDe, string body, string nguoiNhan)
        {
            SendEmail.NguoiNhan = nguoiNhan;

            string result = "Đã gửi mã xác nhận, vui lòng kiểm tra mail!";

            try
            {
                MailMessage mail = new MailMessage();
                mail.To.Add(NguoiNhan);
                mail.From = new MailAddress(senderID);
                mail.Subject = tieuDe;
                mail.Body = body;
                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Credentials = new System.Net.NetworkCredential(senderID, senderPassword);
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Send(mail);
            }
            catch (Exception a)
            {
                result = "Problem occurred: " + a.Message;
            }

            MessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
