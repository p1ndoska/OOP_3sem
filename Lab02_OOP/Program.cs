using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_OOP
{
    //Определить класс, указанный в варианте
    public partial class Book
    {
        private readonly int id;
        private string title;
       

        private string author;
        private string publishingHouse;
        private int theYearOfPublishing;
        private int numberOfPages;
        private int price;
        private string bindingType;

        //Не менее трех конструкторов(с параметрами и без, а также с параметрами по умолчанию);
        //полный конструктор с параметрами по умолчанию
        public Book(int id, string title1, string author1, string publishingHouse1,int numberOfPages1, int theYearOfPublishing1, int price1, string bindingType1)
        {
            title = title1;
            author = author1;
            publishingHouse = publishingHouse1;
            theYearOfPublishing = theYearOfPublishing1;
            numberOfPages = numberOfPages1;
            price = price1;
            bindingType = bindingType1;
            id = this.GetHashCode();
        }
        //конструктор с неполными парметрами
        public Book(int id, string author1)
        {
            id = this.GetHashCode();
            author = author1;/////
        }
        //конструктор без параметров
        public Book( )
        {
            title = "неизвестно";
            author = "неизвестно";
            publishingHouse = "неизвестно";
            theYearOfPublishing = 0;
            numberOfPages = 0;
            price = 0;
            bindingType = "неизвестно";
            id = this.GetHashCode();
        }
    }
    
}
