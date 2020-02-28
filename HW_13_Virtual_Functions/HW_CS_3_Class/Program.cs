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
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Student st = new Student("Alex", "Maloivan", "Oleksandrovich", "VPO19-2");
            for (int i = 0; i < 15; ++i)
            {
                st.AddMark(Subject.Programming, rnd.Next(1, 12));
                st.AddMark(Subject.Administration, rnd.Next(1, 12));
                st.AddMark(Subject.Design, rnd.Next(1, 12));
            }

            st.print();
            Console.ReadKey();
        }
    }
}
