using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMenu { 
    delegate void MenuDelegate(object obj);
    class MenuItem : IComparable<MenuItem> {
        public string MenuString { get; }
        public event MenuDelegate action;
        public MenuItem(string str, MenuDelegate d) {
            MenuString = str;
            action += d;
        }
        public void DoWork(object obj) {
            action?.Invoke(obj);
        }

        public int CompareTo(MenuItem obj) {
            return MenuString.CompareTo(obj.MenuString);
        }
    }

    class Menu {
        private List<MenuItem> items;
        private ConsoleColor m_fgColor;
        private ConsoleColor m_bgColor;
        public int m_hPos;
        public int m_wPos;

        public Menu(int xPos, int yPos, ConsoleColor bgColor = ConsoleColor.Black, ConsoleColor fgColor = ConsoleColor.White) {
            items = new List<MenuItem>();
            m_bgColor = bgColor;
            m_fgColor = fgColor;
            m_hPos = yPos;
            m_wPos = xPos;
        }
        public void Add(string str, MenuDelegate d) {
            MenuItem item = items.Find(x => x.MenuString == str);
            if (item == null) {
                items.Add(new MenuItem(str, d));
            } else {
                item.action += d;
            }
        }
        public void Show() {
            int choose = 0;

            while (true) {
                Console.BackgroundColor = m_bgColor;
                Console.ForegroundColor = m_fgColor;
                Console.SetCursorPosition(m_wPos, m_hPos);

                for (int i = 0; i < items.Count; ++i) {
                    Console.BackgroundColor = m_bgColor;
                    Console.ForegroundColor = m_fgColor;

                    if (i == choose) {
                        Console.BackgroundColor = m_fgColor;
                        Console.ForegroundColor = m_bgColor;

                    }

                    Console.SetCursorPosition(m_wPos - items[i].MenuString.Length/2, m_hPos+i-items.Count/2);
                    Console.Write(items[i].MenuString);
                }

                switch (Console.ReadKey().Key) {
                    case ConsoleKey.UpArrow:
                        --choose;
                        break;
                    case ConsoleKey.DownArrow:
                        ++choose;
                        break;
                    case ConsoleKey.Enter:
                        items[choose].DoWork(new object());
                        Console.ReadKey();
                        break;
                }
                if (choose < 0) choose = items.Count - 1;
                if (choose >= items.Count) choose = 0;
            }
        }
    }
}
