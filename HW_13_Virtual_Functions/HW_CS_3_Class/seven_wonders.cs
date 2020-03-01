using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenWonders
{
    /// <summary>
    /// 9 Разработайте приложение «7 чудес света», где каждое
    ///чудо будет представлено отдельным классом Создайте дополнительный класс, содержащий точку входа
    ///Распределите приложение по файлам проекта и с помощью пространства имён обеспечьте возможность
    ///взаимодействия классов
    /// </summary>
    public class first_wonder
    {
        public string wonder { get; private set; } = "Great Pyramid of Giza";
    }

    class seconds_wonder
    {
        public string wonder { get; private set; } = "Colossus of Rhodes";
    }

    class third_wonder
    {
        public string wonder { get; private set; } = "Hanging Gardens of Babylon";
    }

    class fourth_wonder
    {
        public string wonder { get; private set; } = "Lighthouse of Alexandria";
    }

    class fifth_wonder
    {
        public string wonder { get; private set; } = "Mausoleum at Halicarnassus";
    }
    
    class sixth_wonder
    {
        public string wonder { get; private set; } = "Statue of Zeus at Olympia";
    }
    
    class seventh_wonder
    {
        public string wonder { get; private set; } = "Temple of Artemis";
    }
}
