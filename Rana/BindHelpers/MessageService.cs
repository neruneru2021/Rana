﻿using System.Windows.Forms;

namespace Rana.BindHelpers
{
    /// <summary>
    /// メッセージサービス
    /// </summary>
    public sealed class MessageService : IMessageService
    {
        public void OKOnly(string message)
        {
            MessageBox.Show(
                message,
                "Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public DialogResult QuestionOKCancel(string message)
        {
            return MessageBox.Show(
               message,
               "Question",
               MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question);
        }
    }
}