Console.OutputEncoding = System.Text.Encoding.UTF8;
while (true)
{
    Console.WriteLine("Введите месяц: ");

    int month = int.Parse(Console.ReadLine());

    Console.WriteLine((season)month + ": " + whatSeason((season)month));
}
string whatSeason(season month)
{
    if (month <= (season)2 || month == (season)12) return "Зима" ;
    if (month <= (season)5) return "Весна";
    if (month <= (season)8) return "Лето";
    if (month <= (season)11) return "Осень";
    else return "Не подходит";
} 

enum season
{
    Январь = 1,
    Февраль,
    Март,
    Апрель,
    Май,
    Июнь,
    Июль,
    Август,
    Сентябрь,
    Октябрь,
    Ноябрь,
    Декабрь
}