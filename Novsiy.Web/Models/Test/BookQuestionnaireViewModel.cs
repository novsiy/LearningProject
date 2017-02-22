using Novsiy.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Novsiy.Web.Models.Test
{
    public class BookQuestionnaireViewModel
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string BookName { get; set; }

        public string BookAuthor { get; set; }

        public string Result { get; set; }

        public BookQuestionnaire ToBookQuestionnaire()
        {
            var result = new BookQuestionnaire
            {
                UserName = this.UserName,
                BookAuthor = this.BookAuthor,
                BookName = this.BookName
            };

            return result;
        }

        public static BookQuestionnaireViewModel ToModel(BookQuestionnaire bookQuestionnaire)
        {
            var result = new BookQuestionnaireViewModel
            {
                Id = bookQuestionnaire.Id,
                UserName = bookQuestionnaire.UserName,
                BookAuthor = bookQuestionnaire.BookAuthor,
                BookName = bookQuestionnaire.BookName
            };

            return result;
        }
    }
}