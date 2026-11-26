using System;
using System.Windows;
using System.Windows.Input;
using Interface_Shapovalova.Classes;

namespace Interface_Shapovalova
{
    public partial class MainWindow : Window
    {
        public UsersContext usersContext = new Classes.UsersContext();
        public MessagesContext messagesContext = new MessagesContext();
        public int IdSelectUser = -1;
        public static MainWindow mainWindow;

        public MainWindow()
        {
            InitializeComponent();
            mainWindow = this;
            LoadUser();
        }

        public void LoadUser()
        {
            foreach (Models.Users User in usersContext.AllUsers)
                ParentUser.Children.Add(new Elements.Users(User));
        }

        public void SelectUser(Models.Users User)
        {
            if (User != null)
                IdSelectUser = usersContext.AllUsers.FindIndex(x => x == User);

            parentMessage.Children.Clear();
            foreach (MessagesContext Messages in MessagesContext.AllMessages.FindAll(x => x.IdUser == IdSelectUser))
                parentMessage.Children.Add(new Elements.Messages(Messages));
        }

        private void SendMessages(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
            {
                if (IdSelectUser == -1) return;

                MessagesContext newMessages = new MessagesContext(Message.Text, DateTime.Now, IdSelectUser);
                newMessages.Save();
                Message.Text = "";
                parentMessage.Children.Clear();
                foreach (MessagesContext Messages in MessagesContext.AllMessages.FindAll(x => x.IdUser == IdSelectUser))
                    parentMessage.Children.Add(new Elements.Messages(Messages));
            }
        }
    }
}