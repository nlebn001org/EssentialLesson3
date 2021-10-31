using System;

namespace EssentialLesson3Task4
{
    class ExpertDocumentWorker : ProDocumentWorker
    {

        public override void OpenDocument()
        {
            base.OpenDocument();
        }

        public override void EditDocument()
        {
            base.EditDocument();
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }
}
