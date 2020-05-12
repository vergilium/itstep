using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SevenWonders;

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
    public struct Marks
    {
        private int[][] m_marks;
        public int index { get; set; }
        public Marks(uint mBuff = 10)
        {
            int subjElems = Enum.GetNames(typeof(Subject)).Length;
            m_marks = new int[subjElems][];
            for (int i = 0; i < subjElems; ++i)
            {
                m_marks[i] = new int[mBuff];
            }
            index = 0;
        }

        public int this[int subj]
        {
            get
            {
                var buf = Array.FindAll(m_marks[subj], elem => elem != 0);
                
                return buf[++index < buf.Length?index:index=0];
            }
            set
            {
                if(m_marks[subj].Count(s => s != 0) >= m_marks[subj].Length)
                {
                    int[] buf = new int[m_marks[subj].Length + 10];
                    Array.Copy(m_marks[subj], buf, m_marks[subj].Length);
                    m_marks[subj] = buf;
                }

                m_marks[subj][Array.IndexOf(m_marks[subj], 0)] = value;
                
            }
        }

        public int _getLenght(int subj)
        {
            return Array.FindAll(m_marks[subj], elem => elem != 0).Count();
        }
    }
    class Student
    {
        public string m_firstName { get; private set; }
        public string m_lastName { get; private set; }
        public string m_surNmae { get; private set; }
        public string m_groupe { get; private set; }
        public Marks m_marks;
        public Student(string firstName, string lastName, string surNmae, string groupe)
        {
            m_firstName = firstName;
            m_lastName = lastName;
            m_surNmae = surNmae;
            m_groupe = groupe;
            m_marks = new Marks(10);
        }

        public void AddMark(Subject subj, int mark)
        {
            m_marks[(int)subj] = mark;
        }

        public float avgMarks(int subj)
        {
            int i, sum = 0;
            for (i=0; i<m_marks._getLenght(subj); ++i)
            { 
                m_marks.index = i;
                sum += m_marks[subj];
            }
            return (i>0)?(sum / i):0;
        }

        public void print()
        {
            Console.WriteLine($"Student fullname: {m_firstName} {m_lastName} {m_surNmae}");
            Console.WriteLine($"Student groupe {m_groupe}");
            for (int i = 0; i < Enum.GetNames(typeof(Subject)).Length; i++)
            {
                Console.Write($"Marks of {Enum.GetName(typeof(Subject), i)}: ");
                    for(int s=0; s<m_marks._getLenght(i); ++s)
                    {
                        Console.Write($" { m_marks[i]} |");
                    }
                Console.WriteLine($" Average: {avgMarks(i)}");
            }
        }
    }
    /// <summary>
    /// 10 Разработать приложение, в котором бы сравнивалось
    ///население трёх столиц из разных стран Причём страна бы обозначалась пространством имён, а город —
    ///классом в данном пространстве
    /// </summary>
    namespace Ukraine
    {
        public class Kyiv
        {
            public uint population { get; private set; } = 3700000;
        }
    }
    namespace USA
    {
        public class Vashington
        {
            public uint population { get; private set; } = 601723;
        }
    }
    namespace China
    {
        public class Pekin
        {
            public uint population { get; private set; } = 21705000;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////К заданию 8
            Random rnd = new Random();
            Student st = new Student("Alex", "Maloivan", "Oleksandrovich", "VPO19-2");
            for (int i = 0; i < 15; ++i)
            {
                st.AddMark(Subject.Programming, rnd.Next(1, 12));
                st.AddMark(Subject.Administration, rnd.Next(1, 12));
                st.AddMark(Subject.Design, rnd.Next(1, 12));
            }

            st.print();


            //К заданию 10
            Ukraine.Kyiv kyiv = new Ukraine.Kyiv();
            USA.Vashington vash = new USA.Vashington();
            China.Pekin pek = new China.Pekin();
            if(kyiv.population > vash.population && kyiv.population > pek.population) Console.WriteLine($"In Kyiv lives {kyiv.population} peoples.");
            if(vash.population > kyiv.population && vash.population > pek.population) Console.WriteLine($"In Vashington lives {vash.population} peoples.");
            if(pek.population > kyiv.population && pek.population > vash.population) Console.WriteLine($"In Pekin lives {pek.population} peoples.");
            Console.WriteLine("It`s more than others =)");



            Console.ReadKey();
        }
    }
}

namespace SevenWonders
{
    /// <summary>
    /// 9 Разработайте приложение «7 чудес света», где каждое
    ///чудо будет представлено отдельным классом Создайте дополнительный класс, содержащий точку входа
    ///Распределите приложение по файлам проекта и с помощью пространства имён обеспечьте возможность
    ///взаимодействия классов
    /// </summary>
    /// 
    class SevenWonders
    {
        static void Main(string[] args)
        {
            first_wonder piramid = new first_wonder();
            seconds_wonder colossus = new seconds_wonder();
            third_wonder hanging = new third_wonder();
            fourth_wonder lighthouse = new fourth_wonder();
            fifth_wonder mausoleum = new fifth_wonder();
            sixth_wonder zeuse = new sixth_wonder();
            seventh_wonder temple = new seventh_wonder();

        }
    }
}