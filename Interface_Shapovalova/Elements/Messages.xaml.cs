using System;
using System.Windows.Controls;
using System.Windows.Input;
using Interface_Shapovalova.Classes;

namespace Interface_Shapovalova.Elements
{
    public partial class Messages : UserControl
    {
        public MessagesContext ThisMessage;

        public Messages(Classes.MessagesContext messages)
        {
            InitializeComponent();
            ThisMessage = messages;
            Message.Text = messages.Message;
            Date.Text = messages.Create.ToString("dd.MM.yyyy");
        }

        private void EditMessage(object sender, MouseButtonEventArgs e)
        {
            MainWindow.mainWindow.Message.Text = ThisMessage.Message;

            ThisMessage.Delete();
            MainWindow.mainWindow.parentMessage.Children.Remove(this);

            MainWindow.mainWindow.Message.Focus();
            MainWindow.mainWindow.Message.CaretIndex = MainWindow.mainWindow.Message.Text.Length;
        }

        private void DeleteMessage(object sender, MouseButtonEventArgs e)
        {
            ThisMessage.Delete();
            MainWindow.mainWindow.parentMessage.Children.Remove(this);
        }
    }
}