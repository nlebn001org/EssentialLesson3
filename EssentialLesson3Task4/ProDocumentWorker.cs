using System;

namespace EssentialLesson3Task4
{
    class ProDocumentWorker : DocumentWorker
    {

        public override void OpenDocument()
        {
            base.OpenDocument();
        }

        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
        }
    }
}
