using System.Windows.Forms;

namespace Rana.BindHelpers
{
    /// <summary>
    /// メッセージサービス
    /// </summary>
    public interface IMessageService
    {
        void OKOnly(string message);
        DialogResult QuestionOKCancel(string message);
    }
}