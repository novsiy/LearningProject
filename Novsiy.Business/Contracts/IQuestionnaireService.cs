using Novsiy.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novsiy.Business.Contracts
{
    public interface IQuestionnaireService
    {
        BookQuestionnaire SaveBookQuestionnaireResult(BookQuestionnaire bookQuestionnaire);
    }
}
