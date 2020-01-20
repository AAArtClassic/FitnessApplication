using System;


namespace FitnessApplicationBL.MODEL
{
    /// <summary>
    /// Пользователь
    /// </summary>
    class User
    {
        public string Name { get; }

        public Gender Gender { get; }

        public DateTime BirthDate { get; }

        public double Weight { get; set; }

        public double Hieght { get; set; }

        public User(string name, Gender gender, DateTime birthDate, double weight, double hieght)
        {
            #region Проверка
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя не может быть null", nameof(name));
            }
            if(gender == null)
            {
                throw new ArgumentNullException("Пол не может быть null", nameof(gender));
            }
            if(birthDate<DateTime.Parse("01.01.1900") || birthDate >= DateTime.Now)
            {
                throw new ArgumentException("Невозможная дата рождения", nameof(birthDate));
            }
            if(weight <= 0)
            {
                throw new ArgumentException("Вес не может быть меньше null", nameof(weight));
            }
            if (hieght <= 0)
            {
                throw new ArgumentException("Рост не может быть меньше null", nameof(hieght));
            }
            #endregion

            Name = name;
            Gender = gender;
            BirthDate = birthDate;
            Weight = weight;
            Hieght = hieght;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
