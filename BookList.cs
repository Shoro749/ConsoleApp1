using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Створіть додаток «Список книг до прочитання». Додаток
має дозволяти додавати книги до списку, видаляти книги
зі списку, перевіряти чи є книга у списку, і т.д. Використовуйте механізм властивостей, навантаження операторів,
індексаторів.*/

namespace ConsoleApp1
{
    internal class BookList
    {
        private string[] _arr = new string[50];

        public BookList()
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                _arr[i] = " ";
            }
        }

        public BookList(string[] arr)
        {
            _arr = arr;
        }

        public string[] Arr
        {
            get { return _arr; }
            set { _arr = value; }
        }

        public void AddBook(string title)
        {
            for (int i = 0; i < _arr.Length; i++) 
            {
                if (_arr[i] == " " || _arr[i] == null)
                {
                    _arr[i] = title;
                    break;
                }
            }
        }

        public void RemoveBook(string title)
        {
            bool check = false;
            for (int i = 0; i < _arr.Length; i++)
            {
                if (_arr[i] == title)
                {
                    check = true;
                    _arr[i] = " ";
                    break;
                }
            }
            if (check == false)
            {
                Console.WriteLine("Книги в наявності нема!");
            }
        }

        public bool InStock(string title)
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                if (_arr[i] == title)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
