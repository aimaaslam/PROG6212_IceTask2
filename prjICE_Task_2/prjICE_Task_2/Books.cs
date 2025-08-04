using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjICE_Task_2
{
    public class Books
    {
        string bookAuthor, bookTitle, bookGenre;
        int bookPages, bookPublishYear;

        public Books(string bookAuthor, string bookTitle, string bookGenre, int bookPages, int bookPublishYear)
        {
            this.bookAuthor = bookAuthor;
            this.bookTitle = bookTitle;
            this.bookGenre = bookGenre;
            this.bookPages = bookPages;
            this.bookPublishYear = bookPublishYear;
        }

        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return this.bookAuthor;
                else if (index == 1)
                    return this.bookTitle;
                else if (index == 2)
                    return this.bookGenre;
                else if (index == 3)
                    return this.bookPages;
                else if (index == 4)
                    return this.bookPublishYear;
                return null;
            }
            set
            {
                if (index == 0)
                    this.bookAuthor = (string)value;
                else if (index == 1)
                    this.bookTitle = (string)value;
                else if (index == 2)
                    this.bookGenre = (string)value;
                else if (index == 3)
                    this.bookPages = (int)value;
                else if (index == 4)
                    this.bookPublishYear = (int) value;
            }
        }

        public object this[string attrName]
        {
            get
            {
                if (attrName == "author")
                    return this.bookAuthor;
                else if (attrName == "title")
                    return this.bookTitle;
                else if (attrName == "genre")
                    return this.bookGenre;
                else if (attrName == "pages")
                    return this.bookPages;
                else if (attrName == "year")
                    return this.bookPublishYear;
                return null;
            }
            set
            {
                if (attrName.ToLower().Equals("author"))
                    this.bookAuthor = (string)value;
                else if (attrName.ToLower().Equals("title"))
                    this.bookTitle = (string)value;
                else if (attrName.ToLower().Equals("genre"))
                    this.bookGenre = (string)value;
                else if (attrName.ToLower().Equals("pages"))
                    this.bookPages = (int)value;
                else if (attrName.ToLower().Equals("year"))
                    this.bookPublishYear = (int)value;
            }
        }
    }
}
