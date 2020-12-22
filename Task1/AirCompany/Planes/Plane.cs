using System;
/*
 * Реализовать консольное приложение, удовлетворяющее следующим требованиям:

1.  Выполнить анализ и декомпозицию предметной области.  30 %
2.	Использовать возможности ООП: наследование, полиморфизм, инкапсуляция.Отразить декомпозицию в структуре классов.  30 %
3.	Каждый класс должен иметь исчерпывающее смысл название и информативный состав.  15 %
4.	При кодировании следует придерживаться соглашения об оформлении кода code convention. (TO DO, FAQ) 15 %
5.  Файлы проекта должны быть разделены по папкам согласно доменной модели. 5 %
6.	Работа с консолью или консольное меню должно быть минимальным. 5 %

* Авиакомпания. 
* Определить иерархию самолетов. 
* Создать авиакомпанию. Посчитать общую вместимость и грузоподъемность. 
* Провести сортировку самолетов компании по дальности полета. 
* Найти самолет в компании, соответствующий заданному диапазону параметров потребления горючего.
*/
namespace AirCompany.Planes
{
    public abstract class Plane
    {
        public string UniqueNumber { get; set;}
        public PlaneModel PlaneModel { get; set; }
        public PlaneType PlaneType { get; set; }
        public PlaneSpecification PlaneSpecification { get; set; }
        public double MaxFlyDistance => Math.Round(PlaneSpecification.TankCapacity / PlaneSpecification.FuelConsumption) * 1000;
        public Plane()
        { }
        public Plane(string uniqueNumber, PlaneModel planeModel)
        {
            UniqueNumber = uniqueNumber;
            PlaneModel = planeModel;
        }
    }
}
