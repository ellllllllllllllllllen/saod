using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form 
    {
        Tree tree;
        public Form1()
        {
            InitializeComponent();
            
            CreateTree();
        }
        public void CreateTree()
        {
            string[] faculties = new string[] { "АТФ", "ФДГЭ", "МСФ", "МТФ", "ФММП",
                "ЭФ", "ФИТР", "ФТУГ", "ИПФ", "ФЭС", "АФ", "СФ", "ПСФ", "ФТК", "ВТФ", "СТФ"};

            TreeNode univerNode = new TreeNode("БНТУ");
            foreach (string item in faculties)
            {
                univerNode.Nodes.Add(new TreeNode(item));
            }

            treeView1.Nodes.Add(univerNode);
            ///////АТФ
            string[] ATF_departments = new string[] { "Кафедра 'Автомобили'", "Кафедра 'Двигатели внутреннего сгорания'", "Кафедра 'Техническая эксплуатация автомобилей'",
            "Кафедра 'Тракторы'", "Кафедра 'Транспортные системы и технологии'", "Кафедра 'Экономика и логистика'", "Кафедра 'Гидропневмоавтоматика и гидропневмопривод'" };
            foreach (string item in ATF_departments)
            {
                univerNode.Nodes[0].Nodes.Add(new TreeNode(item));
            }

            univerNode.Nodes[0].Nodes[0].Nodes.Add(new TreeNode("Специальность 'Автомобилестроение'"));
            univerNode.Nodes[0].Nodes[0].Nodes[0].Nodes.Add(new TreeNode("Направление 'Механика'"));
            univerNode.Nodes[0].Nodes[0].Nodes[0].Nodes.Add(new TreeNode("Направление 'Электроника'"));
            univerNode.Nodes[0].Nodes[1].Nodes.Add(new TreeNode("Специальность 'Двигатели внутреннего сгорания'"));
            univerNode.Nodes[0].Nodes[2].Nodes.Add(new TreeNode("Специальность 'Техническая эксплуатация автомобилей'"));
            univerNode.Nodes[0].Nodes[2].Nodes.Add(new TreeNode("Специальность 'Автосервис'"));
            univerNode.Nodes[0].Nodes[3].Nodes.Add(new TreeNode("Специальность 'Тракторостроение'"));
            univerNode.Nodes[0].Nodes[3].Nodes.Add(new TreeNode("Специальность 'Многоцелевые гусеничные и колесные машины'"));
            univerNode.Nodes[0].Nodes[3].Nodes.Add(new TreeNode("Специальность 'Дизайн гусенечных и колесных машин'"));
            univerNode.Nodes[0].Nodes[3].Nodes.Add(new TreeNode("Специальность 'Городской электрический транспорт'"));
            univerNode.Nodes[0].Nodes[4].Nodes.Add(new TreeNode("Специальность 'Организация перевозок и управление на автомобильном и городском транспорте'"));
            univerNode.Nodes[0].Nodes[4].Nodes.Add(new TreeNode("Специальность 'Организация дорожного движения'"));
            univerNode.Nodes[0].Nodes[4].Nodes.Add(new TreeNode("Специальность 'Эксплуатация интеллектуальных транспортных систем на автомобильном и городском транспорте'"));
            univerNode.Nodes[0].Nodes[4].Nodes.Add(new TreeNode("Специальность 'Оценочная деятельность на автомобильном транспорте'"));
            univerNode.Nodes[0].Nodes[5].Nodes.Add(new TreeNode("Специальность 'Экономика и организация производства'"));
            univerNode.Nodes[0].Nodes[5].Nodes.Add(new TreeNode("Специальность 'Транспортная логистика'"));
            univerNode.Nodes[0].Nodes[6].Nodes.Add(new TreeNode("Специальность 'Гидропневмосистемы мобильных и технологических машин'"));
            ///////ФДГЭ
            string[] FDGE_departments = new string[] { "Кафедра 'Горные машины'", "Кафедра 'Горные работы'", "Кафедра 'Инженерная экология'" };
            foreach (string item in FDGE_departments)
            {
                univerNode.Nodes[1].Nodes.Add(new TreeNode(item));
            }
            univerNode.Nodes[1].Nodes[0].Nodes.Add(new TreeNode("Специальность 'Горные машины и оборудование'"));
            univerNode.Nodes[1].Nodes[1].Nodes.Add(new TreeNode("Специальность 'Разработка месторождений полезных ископаемых'"));
            univerNode.Nodes[1].Nodes[2].Nodes.Add(new TreeNode("Специальность 'Экологический менеджмент и аудит в промышленности'"));
            ///////МСФ
            string[] MSF_departments = new string[] { "Кафедра 'Технология машиностроения'", "Кафедра 'Технологическое оборудование'", "Кафедра 'Инженерная экономика'",
                "Кафедра 'Интеллектуальные и мехатронные системы'", "Кафедра 'Теоретическая механика и механика материалов'", "Кафедра 'Машиноведение и детали машин'" };
            foreach (string item in MSF_departments)
            {
                univerNode.Nodes[2].Nodes.Add(new TreeNode(item));
            }
            univerNode.Nodes[2].Nodes[0].Nodes.Add(new TreeNode("Специальность 'Технология машиностроения'"));univerNode.Nodes[0].Nodes[0].Nodes.Add(new TreeNode("Специальность 'Автомобилестроение'"));
            univerNode.Nodes[2].Nodes[1].Nodes.Add(new TreeNode("Специальность 'Металлорежущие станки'"));
            univerNode.Nodes[2].Nodes[1].Nodes.Add(new TreeNode("Специальность 'Инструментальное производство'"));
            univerNode.Nodes[2].Nodes[2].Nodes.Add(new TreeNode("Специальность 'Экономика и организация производства'"));
            univerNode.Nodes[2].Nodes[2].Nodes[0].Nodes.Add(new TreeNode("Направление 'Инженерная экономика'"));
            univerNode.Nodes[2].Nodes[2].Nodes[0].Nodes.Add(new TreeNode("Направление 'Контроллинг'"));
            univerNode.Nodes[2].Nodes[2].Nodes[0].Nodes.Add(new TreeNode("Направление 'Производственная логистика'"));
            univerNode.Nodes[2].Nodes[3].Nodes.Add(new TreeNode("Специальность 'Интеллектуальные приборы, машины и производства'"));
            univerNode.Nodes[2].Nodes[3].Nodes.Add(new TreeNode("Специальность 'Интегральные сенсорные системы'"));
            univerNode.Nodes[2].Nodes[5].Nodes.Add(new TreeNode("Специальность 'Детали машин, подъемно-транспортные машины и механизмы'"));
            ///////МТФ
            string[] MTF_departments = new string[] { "Кафедра 'Машины и технология обработки металлов давлением'", "Кафедра 'Металлургия черных и цветных сплавов'",
                "Кафедра 'Материаловедение в машиностроении'", "Кафедра 'Порошковая металлургия, сварка и технология материалов'", "Кафедра 'Машины и технология литейного производства'" };
            foreach (string item in MTF_departments)
            {
                univerNode.Nodes[3].Nodes.Add(new TreeNode(item));
            }
            univerNode.Nodes[3].Nodes[0].Nodes.Add(new TreeNode("Специальность 'Машины и технология обработки металлов давлением'"));
            univerNode.Nodes[3].Nodes[1].Nodes.Add(new TreeNode("Специальность 'Металлургическое производство и материалообработка'"));
            univerNode.Nodes[3].Nodes[1].Nodes[0].Nodes.Add(new TreeNode("Направление 'Металлургия'"));
            univerNode.Nodes[3].Nodes[1].Nodes[0].Nodes.Add(new TreeNode("Направление 'Материалообработка'"));
            univerNode.Nodes[3].Nodes[2].Nodes.Add(new TreeNode("Специальность 'Материаловедение в машиностроении'"));
            univerNode.Nodes[3].Nodes[3].Nodes.Add(new TreeNode("Специальность 'Оборудо и технология сварочного производства'"));
            univerNode.Nodes[3].Nodes[4].Nodes.Add(new TreeNode("Специальность 'Машины и технология литейного производства'"));

            ///////ФММП
            string[] FMMP_departments = new string[] { "Кафедра 'Бизнес-администрирование'", "Кафедра 'Маркетинг'", "Кафедра 'Торговое и рекламное оборудование'",
                "Кафедра 'Экономика и управление инновационными проектами в промышленности'" };
            foreach (string item in FMMP_departments)
            {
                univerNode.Nodes[4].Nodes.Add(new TreeNode(item));
            }
            univerNode.Nodes[4].Nodes[0].Nodes.Add(new TreeNode("Специальность 'Бизнес-администрирование'"));
            univerNode.Nodes[4].Nodes[1].Nodes.Add(new TreeNode("Специальность 'Маркетинг'"));
            univerNode.Nodes[4].Nodes[2].Nodes.Add(new TreeNode("Специальность 'Торговое оборудование и технологии'"));
            univerNode.Nodes[4].Nodes[2].Nodes.Add(new TreeNode("Специальность 'Производство экспозиционно-рекламных объектов'"));
            univerNode.Nodes[4].Nodes[3].Nodes.Add(new TreeNode("Специальность 'Экономика и управление на предприятии'"));
            univerNode.Nodes[4].Nodes[3].Nodes.Add(new TreeNode("Специальность 'Управление инновационными проектами промышленных предприятий'"));
            univerNode.Nodes[4].Nodes[3].Nodes.Add(new TreeNode("Специальность 'Управление дизайн-проектами на промышленном предприятии'"));
            ///////ЭФ
            string[] EF_departments = new string[] { "Кафедра 'Электрические системы'", "Кафедра 'Электрические станции'", "Кафедра 'Электроснабжение'",
                "Кафедра 'Экономика и организация энергетики'", "Кафедра 'Промышленная теплоэнергетика и теплотехника'" };
            foreach (string item in EF_departments)
            {
                univerNode.Nodes[5].Nodes.Add(new TreeNode(item));
            }
            univerNode.Nodes[5].Nodes[0].Nodes.Add(new TreeNode("Специальность 'Проектирование и эксплуатация электроэнергетических систем'"));
            univerNode.Nodes[5].Nodes[0].Nodes.Add(new TreeNode("Специальность 'Проектирование, монтаж и эксплуатация электрических сетей'"));
            univerNode.Nodes[5].Nodes[0].Nodes.Add(new TreeNode("Специальность 'Диспетчерское управление электроэнергетическими системами и сетями'"));
            univerNode.Nodes[5].Nodes[1].Nodes.Add(new TreeNode("Специальность 'Электрические станции'"));
            univerNode.Nodes[5].Nodes[1].Nodes.Add(new TreeNode("Специальность 'Релейная защита и автоматика'"));
            univerNode.Nodes[5].Nodes[2].Nodes.Add(new TreeNode("Специальность 'Электроснабжение промышленных предприятий'"));
            univerNode.Nodes[5].Nodes[3].Nodes.Add(new TreeNode("Специальность 'Экономика и организация производства'"));
            univerNode.Nodes[3].Nodes[3].Nodes[0].Nodes.Add(new TreeNode("Направление 'Энергетика'"));
            univerNode.Nodes[5].Nodes[4].Nodes.Add(new TreeNode("Специальность 'Промышленная теплоэнергетика'"));
            univerNode.Nodes[5].Nodes[4].Nodes.Add(new TreeNode("Специальность 'Теплоэнергетические установки и системы теплоснабжения'"));
            ///////ФИТР
            string[] FITR_departments = new string[] { "Кафедра 'Программное обеспечение информационных систем и технологий'", "Кафедра 'Робототехнические системы'",
                "Кафедра 'Электропривод и автоматизация промышленных установок и технологических комплексов'", "Кафедра 'Техническая физика'", "Кафедра 'Высшая математика'" };
            foreach (string item in FITR_departments)
            {
                univerNode.Nodes[6].Nodes.Add(new TreeNode(item));
            }
            univerNode.Nodes[6].Nodes[0].Nodes.Add(new TreeNode("Специальность 'Программное обеспечение информационных технологий'"));
            univerNode.Nodes[6].Nodes[0].Nodes.Add(new TreeNode("Специальность 'Информационные системы и технологии'"));
            univerNode.Nodes[6].Nodes[0].Nodes[1].Nodes.Add(new TreeNode("Направление 'Информационные системы и технологии в обработке и представлении информации'"));
            univerNode.Nodes[6].Nodes[0].Nodes[1].Nodes.Add(new TreeNode("Направление 'Информационные системы и технологии в проектировании и производстве'"));
            univerNode.Nodes[6].Nodes[1].Nodes.Add(new TreeNode("Специальность 'Автоматизация технологических процессов и производств'"));
            univerNode.Nodes[6].Nodes[1].Nodes.Add(new TreeNode("Специальность 'Промышленные роботы и робототехнические комплексы'"));
            univerNode.Nodes[6].Nodes[2].Nodes.Add(new TreeNode("Специальность 'Автоматизированные электроприводы'"));
            ///////ФТУГ
            string[] FTUG_departments = new string[] { "Кафедра 'Промышленный дизайн и упаковка'", "Кафедра 'Энергосбережение и возобновляемые источники энергии'",
                "Кафедра 'Таможенное дело'", "Кафедра 'Иностранные языки'", "Кафедра 'История белорусской государственности'", "Кафедра 'Менеджмент'",
                "Кафедра 'Философские учения'", "Кафедра 'Экономика и право'", "Кафедра 'Белорусский и русский языки'" };
            foreach (string item in FTUG_departments)
            {
                univerNode.Nodes[7].Nodes.Add(new TreeNode(item));
            }
            univerNode.Nodes[7].Nodes[0].Nodes.Add(new TreeNode("Специальность 'Упаковочное производство'"));
            univerNode.Nodes[7].Nodes[0].Nodes.Add(new TreeNode("Специальность 'Дизайн производственного оборудования'"));
            univerNode.Nodes[7].Nodes[1].Nodes.Add(new TreeNode("Специальность 'Энергоэффективные технологии и энергетический менеджмент'"));
            univerNode.Nodes[7].Nodes[1].Nodes.Add(new TreeNode("Специальность 'Низкотемпературная техника'"));
            univerNode.Nodes[7].Nodes[2].Nodes.Add(new TreeNode("Специальность 'Экономическое обеспечение таможенной деятельности'"));
            univerNode.Nodes[7].Nodes[5].Nodes.Add(new TreeNode("Специальность 'Менеджмент'"));
            univerNode.Nodes[7].Nodes[5].Nodes[0].Nodes.Add(new TreeNode("Направление 'Менеджмент (международный)'"));
            univerNode.Nodes[7].Nodes[5].Nodes[0].Nodes.Add(new TreeNode("Направление 'Менеджмент (недвижимости)'"));
            univerNode.Nodes[7].Nodes[5].Nodes[0].Nodes.Add(new TreeNode("Направление 'Менеджмент (социально-административный)'"));
            univerNode.Nodes[7].Nodes[7].Nodes.Add(new TreeNode("Специальность 'Экономика и управление на предприятии'"));
            univerNode.Nodes[7].Nodes[7].Nodes.Add(new TreeNode("Специальность 'Экономика и организация производства'"));
            ///////ИПФ
            string[] IPF_departments = new string[] { "Кафедра 'Вакуумная и компрессорная техника'", "Кафедра 'Профессиональное обучение и педагогика'", "Кафедра 'Психология'",
                "Кафедра 'Технология и методика преподавания'" };
            foreach (string item in IPF_departments)
            {
                univerNode.Nodes[8].Nodes.Add(new TreeNode(item));
            }
            univerNode.Nodes[8].Nodes[0].Nodes.Add(new TreeNode("Специальность 'Вакуумная и компрессорная техника'"));
            univerNode.Nodes[8].Nodes[2].Nodes.Add(new TreeNode("Специальность 'Инженерная психология, педагогика и управление коллективом'"));
            univerNode.Nodes[8].Nodes[3].Nodes.Add(new TreeNode("Специальность 'Профессиональное обучение'"));
            univerNode.Nodes[8].Nodes[3].Nodes[0].Nodes.Add(new TreeNode("Направление 'Профессиональное обучение (деревообработка)'"));
            univerNode.Nodes[8].Nodes[3].Nodes[0].Nodes.Add(new TreeNode("Направление 'Профессиональное обучение (информатика)'"));
            
            ///////ФЭС
            string[] FES_departments = new string[] { "Кафедра 'Гидротехническое и энергетическое строительство, водный транспорт и гидравлика'",
                "Кафедра 'Водоснабжение и водоотведение'", "Кафедра 'Теплогазоснабжение и вентиляция'", "Кафедра 'Физика'" };
            foreach (string item in FES_departments)
            {
                univerNode.Nodes[9].Nodes.Add(new TreeNode(item));
            }
            univerNode.Nodes[9].Nodes[0].Nodes.Add(new TreeNode("Специальность 'Водохозяйственное строительство'"));
            univerNode.Nodes[9].Nodes[0].Nodes.Add(new TreeNode("Специальность 'Строительство тепловых и атомных электростанций'"));
            univerNode.Nodes[9].Nodes[0].Nodes.Add(new TreeNode("Специальность 'Кораблестроение и техническая эксплуатация водного транспорта'"));
            univerNode.Nodes[9].Nodes[1].Nodes.Add(new TreeNode("Специальность 'Водоснабжение, водоотведение и охрана водных ресурсов'"));
            univerNode.Nodes[9].Nodes[1].Nodes.Add(new TreeNode("Специальность 'Экономика и организация производства (коммунальное и водное хозяйство)'"));
            univerNode.Nodes[9].Nodes[2].Nodes.Add(new TreeNode("Специальность 'Теплогазоснабжение, вентиляция и охрана воздушного бассейна'"));
            
            ///////АФ
            string[] AF_departments = new string[] { "Кафедра 'Теория и история архитектуры'", "Кафедра 'Рисунок, акварель и скульптура'",
                "Кафедра 'Архитектура жилых и общественных зданий'", "Кафедра 'Архитектура производственных объектов и архитектурные конструкции'",
                "Кафедра 'Градостроительство'", "Кафедра 'Дизайн архитектурной среды'" };
            foreach (string item in AF_departments)
            {
                univerNode.Nodes[10].Nodes.Add(new TreeNode(item));
            }
            univerNode.Nodes[10].Nodes[0].Nodes.Add(new TreeNode("Специальность 'Архитектура'"));
            univerNode.Nodes[10].Nodes[0].Nodes.Add(new TreeNode("Специальность 'Архитектурный дизайн'"));
            univerNode.Nodes[10].Nodes[1].Nodes.Add(new TreeNode("Специальность 'Архитектура'"));
            univerNode.Nodes[10].Nodes[2].Nodes.Add(new TreeNode("Специальность 'Дизайн архитектурной среды'"));
            
            ///////СФ
            string[] SF_departments = new string[] { "Кафедра 'Строительные конструкции'", "Кафедра 'Экономика, организация строительства и управление недвижимостью'",
                "Кафедра 'Геотехника и строительная механика'", "Кафедра 'Строительные материалы и технология строительства'", "Кафедра 'Инженерная графика строительного профиля'" };
            foreach (string item in SF_departments)
            {
                univerNode.Nodes[11].Nodes.Add(new TreeNode(item));
            }
            univerNode.Nodes[11].Nodes[0].Nodes.Add(new TreeNode("Специальность 'Промышленное и гражданское строительство'"));
            univerNode.Nodes[11].Nodes[1].Nodes.Add(new TreeNode("Специальность 'Экономика и организация производства'"));
            univerNode.Nodes[11].Nodes[1].Nodes.Add(new TreeNode("Специальность 'Экспертиза и управление недвижимостью'"));
            univerNode.Nodes[11].Nodes[1].Nodes.Add(new TreeNode("Специальность 'Промышленное и гражданское строительство'"));
            univerNode.Nodes[11].Nodes[2].Nodes.Add(new TreeNode("Специальность 'Техническая эксплуатация зданий и сооружений'"));
            univerNode.Nodes[11].Nodes[3].Nodes.Add(new TreeNode("Специальность 'Производство строительных изделий и конструкций'"));
            
            ///////ПСФ
            string[] PSF_departments = new string[] { "Кафедра 'Конструирование и производство приборов'", "Кафедра 'Лазерная техника и технология'",
                "Кафедра 'Информационно-измерительная техника и технологии'", "Кафедра 'Стандартизация, метрология и информационные системы'",
                "Кафедра 'Микро- и нанотехника'", "Кафедра 'Инженерная математика'", "Кафедра 'Экспериментальная и теоретическая физика'" };
            foreach (string item in PSF_departments)
            {
                univerNode.Nodes[12].Nodes.Add(new TreeNode(item));
            }
            univerNode.Nodes[12].Nodes[0].Nodes.Add(new TreeNode("Специальность 'Механические и электромеханические приборы и аппараты'"));
            univerNode.Nodes[12].Nodes[0].Nodes[0].Nodes.Add(new TreeNode("Направление 'Контрольно-измерительные приборы и системы'"));
            univerNode.Nodes[12].Nodes[0].Nodes[0].Nodes.Add(new TreeNode("Направление 'Бытовые машины, приборы и аппараты'"));
            univerNode.Nodes[12].Nodes[0].Nodes[0].Nodes.Add(new TreeNode("Направление 'Технология и оборудование ювелирного производства'"));
            univerNode.Nodes[12].Nodes[0].Nodes[0].Nodes.Add(new TreeNode("Направление 'Биотехнические и медицинские аппараты и системы'"));
            univerNode.Nodes[12].Nodes[1].Nodes.Add(new TreeNode("Специальность 'Оптико-электронные и лазерные приборы и системы'"));
            univerNode.Nodes[12].Nodes[1].Nodes[0].Nodes.Add(new TreeNode("Направление 'Оптические и оптико-электронные приборы и комплексы'"));
            univerNode.Nodes[12].Nodes[1].Nodes[0].Nodes.Add(new TreeNode("Направление 'Лазерные системы и технологии'"));
            univerNode.Nodes[12].Nodes[1].Nodes[0].Nodes.Add(new TreeNode("Направление 'Светотехника и источники света'"));
            univerNode.Nodes[12].Nodes[2].Nodes.Add(new TreeNode("Специальность 'Информационно-измерительная техника'"));
            univerNode.Nodes[12].Nodes[2].Nodes[0].Nodes.Add(new TreeNode("Направление 'Информационно-измерительная техника в системах управления'"));
            univerNode.Nodes[12].Nodes[2].Nodes[0].Nodes.Add(new TreeNode("Направление 'Техническое обеспечение безопасности'"));
            univerNode.Nodes[12].Nodes[2].Nodes[0].Nodes.Add(new TreeNode("Направление 'Приборы и системы охранной сигнализации и безопасности'"));
            univerNode.Nodes[12].Nodes[3].Nodes.Add(new TreeNode("Специальность 'Метрология, стандартизация и сертификация'"));
            univerNode.Nodes[12].Nodes[4].Nodes.Add(new TreeNode("Специальность 'Технология материалов и компонентов электронной техники'"));
            univerNode.Nodes[12].Nodes[4].Nodes[0].Nodes.Add(new TreeNode("Направление 'Технология материалов и компонентов электронной техники'"));
            univerNode.Nodes[12].Nodes[4].Nodes[0].Nodes.Add(new TreeNode("Направление 'Технология компонентов нано- и микросистемной техники'"));
            
            ///////ФТК
            string[] FTK_departments = new string[] { "Кафедра 'Автомобильные дороги'", "Кафедра 'Мосты и тоннели'", "Кафедра 'Механизация и автоматизация дорожно-строительного комплекса'",
                "Кафедра 'Геодезия и аэрокосмические геотехнологии'", "Кафедра 'Математические методы в строительстве'" };
            foreach (string item in FTK_departments)
            {
                univerNode.Nodes[13].Nodes.Add(new TreeNode(item));
            }
            univerNode.Nodes[13].Nodes[0].Nodes.Add(new TreeNode("Специальность 'Автомобильные дороги'"));
            univerNode.Nodes[13].Nodes[0].Nodes[0].Nodes.Add(new TreeNode("Направление 'Строительство дорог и аэродромов'"));
            univerNode.Nodes[13].Nodes[1].Nodes.Add(new TreeNode("Специальность 'Экономика и организация производства'"));
            univerNode.Nodes[13].Nodes[1].Nodes[0].Nodes.Add(new TreeNode("Направление 'кономика и организация производства (автодорожное хозяйство)'"));
            univerNode.Nodes[13].Nodes[2].Nodes.Add(new TreeNode("Специальность 'Мосты, транспортные тоннели и метрополитены'"));
            univerNode.Nodes[13].Nodes[2].Nodes[0].Nodes.Add(new TreeNode("Направление 'Мосты'"));
            univerNode.Nodes[13].Nodes[2].Nodes[0].Nodes.Add(new TreeNode("Направление 'Подземные сооружения, тоннели и метрополитены'"));
            univerNode.Nodes[13].Nodes[2].Nodes[0].Nodes.Add(new TreeNode("Направление 'Содержание, реконструкция и ремонт транспортных сооружений'"));
            
            univerNode.Nodes[13].Nodes[3].Nodes.Add(new TreeNode("Специальность 'Подъемно-транспортные, строительные, дорожные машины и оборудование»'"));
            univerNode.Nodes[13].Nodes[3].Nodes[0].Nodes.Add(new TreeNode("Направление 'Подъемно-транспортные машины и оборудование'"));
            univerNode.Nodes[13].Nodes[3].Nodes[0].Nodes.Add(new TreeNode("Направление 'Дорожные машины и оборудование'"));
            univerNode.Nodes[13].Nodes[3].Nodes[0].Nodes.Add(new TreeNode("Направление 'Лифты и грузоподъемное оборудование в зданиях и сооружениях'"));
            univerNode.Nodes[13].Nodes[4].Nodes.Add(new TreeNode("Специальность 'Геодезия'"));
            univerNode.Nodes[13].Nodes[4].Nodes[0].Nodes.Add(new TreeNode("Направление 'Инженерная геодезия'"));
            
            ///////ВТФ
            string[] VTF_departments = new string[] { "Кафедра 'Бронетанковое вооружение и техника'", "Кафедра 'Военная автомобильная техника'", "Кафедра 'Военно-инженерная подготовка'",
                "Кафедра 'Организация финансовой деятельности войск'", "Кафедра 'Тактика и общевоенная подготовка'" };
            foreach (string item in VTF_departments)
            {
                univerNode.Nodes[14].Nodes.Add(new TreeNode(item));
            }
            univerNode.Nodes[14].Nodes[0].Nodes.Add(new TreeNode("Специальность 'Многоцелевые гусеничные и колесные машины'"));
            univerNode.Nodes[14].Nodes[0].Nodes[0].Nodes.Add(new TreeNode("Направление 'Эксплуатация и ремонт бронетанкового вооружения и техники'"));
            univerNode.Nodes[14].Nodes[0].Nodes.Add(new TreeNode("Специальность 'Организация эксплуатации и ремонта бронетанкового вооружения и техники'"));
            univerNode.Nodes[14].Nodes[0].Nodes.Add(new TreeNode("Специальность 'Техник (по ремонту и хранению гусеничной бронетанковой техники и шасси специальных машин на ее базе'"));
            univerNode.Nodes[14].Nodes[0].Nodes.Add(new TreeNode("Специальность 'Техник (по ремонту и хранению электро- и спецоборудования бронетанковой техники)'"));
            
            univerNode.Nodes[14].Nodes[1].Nodes.Add(new TreeNode("Специальность 'Техническая эксплуатация автомобилей'"));
            univerNode.Nodes[14].Nodes[1].Nodes[0].Nodes.Add(new TreeNode("Направление 'Военная автомобильная техника'"));
            univerNode.Nodes[14].Nodes[2].Nodes.Add(new TreeNode("Специальность 'Подъемно-транспортные, строительные, дорожные машины и оборудование'"));
            univerNode.Nodes[14].Nodes[2].Nodes[0].Nodes.Add(new TreeNode("Направление 'Управление подразделениями инженерных войск'"));
            univerNode.Nodes[14].Nodes[2].Nodes.Add(new TreeNode("Специальность 'Боевое применение инженерно-саперных (инженерных) подразделений и частей '"));
            univerNode.Nodes[14].Nodes[2].Nodes[0].Nodes.Add(new TreeNode("Направление 'Эксплуатация и ремонт инженерных машин'"));
            univerNode.Nodes[14].Nodes[3].Nodes.Add(new TreeNode("Специальность 'Командир отделения'"));
            univerNode.Nodes[14].Nodes[3].Nodes[0].Nodes.Add(new TreeNode("Направление 'Командир отделения (инженерно-саперного)'"));
            univerNode.Nodes[14].Nodes[3].Nodes[0].Nodes.Add(new TreeNode("Направление 'Командир отделения (инженерной разведки)'"));
            univerNode.Nodes[14].Nodes[4].Nodes.Add(new TreeNode("Специальность 'Экономика и управление на предприятии'"));
            
            ///////СТФ
            string[] STF_departments = new string[] { "Кафедра 'Физическая культура'", "Кафедра 'Спортивная инженерия'", "Кафедра 'Спорт'" };
            foreach (string item in STF_departments)
            {
                univerNode.Nodes[15].Nodes.Add(new TreeNode(item));
            }
            univerNode.Nodes[15].Nodes[1].Nodes.Add(new TreeNode("Специальность 'Техническое обеспечение эксплуатации спортивных объектов'"));
            univerNode.Nodes[15].Nodes[1].Nodes.Add(new TreeNode("Специальность 'Техническое обеспечение спортивных технологий'"));
            univerNode.Nodes[15].Nodes[1].Nodes.Add(new TreeNode("Специальность 'Проектирование и производство спортивной техники'"));
            
            
        }
        
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            tree = new Tree();
        }
    }
}
