using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_CS_3_Class
{
    /// <summary>
    ///5 Описать перечисление ArticleType определяющее
    ///типы товаров, и добавить соответствующее поле
    ///в структуру Article из задания №1
    /// </summary>
    enum ArticleType : UInt16 { book, magazine, brochure, newspaper };

    /// <summary>
    ///6 Описать перечисление ClientType определяющее
    ///важность клиента, и добавить соответствующее поле
    ///в структуру Client из задания №2
    /// </summary>
    enum ClientType : uint { start, silver, gold, platinum, god };
    
    /// <summary>
    /// 1 Описать структуру Article, содержащую следующие поля: код товара; название товара; цену товара
    /// </summary>
    struct Article
    {
        public int GoodsID;
        public string GoodsName;
        public float GoodsPrice;
        public ArticleType GoodsType;
    }

    /// <summary>
    ///7 Описать перечисление PayTypeопределяющее форму
    ///оплаты клиентом заказа, и добавить соответствующее
    ///поле в структуру Request из задания №4
    /// </summary>
    enum PayType : UInt16 { cash, cashless, payment };
     
    /// <summary>
    /// 2 Описать структуру Client содержащую поля: код
    ///клиента; ФИО; адрес; телефон; количество заказов
    ///осуществленных клиентом; общая сумма заказов клиента
    /// </summary>
    struct Clients {
        public int ID;
        public string FirstName;
        public string LastName;
        public string SurName;
        public string Location;
        public string[] Phones;
        public int countDeals;
        public float sumPayed;
        public ClientType status;
    }
    /// <summary>
    /// 3 Описать структуру RequestItem содержащую поля:
    ///товар; количество единиц товара
    /// </summary>
    struct RequestItem
    {
        public Article Goods;
        public int count;
    }
    /// <summary>
    /// 4 Описать структуру Request содержащую поля: код
    ///заказа; клиент; дата заказа; перечень заказанных товаров;
    ///сумма заказа(реализовать вычисляемым свойством)
    /// </summary>
    struct Request
    {
        public int ID;
        public Clients Client;
        public DateTime dateSale;
        public RequestItem[] Goods;
        public PayType payMethod;
        public float sumOrders {
            get { var sum = 0F;
                for (int i = 0; i < Goods.Length; ++i)
                {
                    sum += Goods[i].count * Goods[i].Goods.GoodsPrice;
                }
                return sum;
            }
        }

    }

    /// <summary>
    /// 8 Придумать класс, описывающий студента Предусмотреть в нем следующие моменты: фамилия, имя,
    ///отчество, группа, возраст, массив(зубчатый) оценок по
    ///программированию, администрированию и дизайну
    ///А также добавить методы по работе с перечисленными
    ///данными: возможность установки/получения оценки, получение среднего балла по заданному предмету,
    ///распечатка данных о студенте
    /// </summary>
    /// 
    enum Subject : UInt16 { Programming, Administration, Design};
    class Student
    {
        public string firstName { get; private set; }
        public string lastName { get; private set; }
        public string surNmae { get; private set; }
        public string groupe { get; private set; }
        public int[][] marks = new int[Enum.GetNames(typeof(Subject)).Length][];

        public void addMark (Subject subj, int mark)
        {
            marks[subj].r
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
