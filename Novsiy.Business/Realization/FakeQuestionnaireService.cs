using Novsiy.Business.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Novsiy.DataModel;

namespace Novsiy.Business.Realization
{
    public class FakeQuestionnaireService : IQuestionnaireService
    {
        public BookQuestionnaire SaveBookQuestionnaireResult(BookQuestionnaire bookQuestionnaire)
        {
            bookQuestionnaire.Id = DateTime.UtcNow.Second;

            return bookQuestionnaire;
        }
    }
}
