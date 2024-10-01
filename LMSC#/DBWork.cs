using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace LMSC_
{
    internal class DBWork
    {   
        //Путь к БД
        static private string path = $"Data Source = LMS.db;";

        
        //Метод для заполнения колкнки weight на основе введенной переменной onePM
        public static void UpdateWight(double onePM)
        {
            using (var conn = new SQLiteConnection(path))
            {
                conn.Open();

                // Получаем данные из таблицы
                string selectQuery = "SELECT id, workLoad_percent FROM TraningExercision";
                using (var selectCommand = new SQLiteCommand(selectQuery, conn))
                using (var reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Получаем id и процент нагрузки из результата запроса
                        int id = reader.GetInt32(0);  //считывание id из первой колонки
                        double loadPercent = reader.GetDouble(1);  // Считывание процента нагрузки из второй колонки

                        // Вычисляем вес для упражнения
                        double weight = (onePM * loadPercent) / 100;

                        // Обновляем колонку weight
                        string updateQuery = "UPDATE TraningExercision SET weight = @weight WHERE id = @id";
                        using (var updateCommand = new SQLiteCommand(updateQuery, conn))
                        {
                            // Передаем вычисленные параметры в запрос
                            updateCommand.Parameters.AddWithValue("@weight", weight);
                            updateCommand.Parameters.AddWithValue("@id", id);

                            // Выполняем запрос обновления
                            updateCommand.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        //Метод загрузки информации из БД
        static public SQLiteDataReader LoadTraningExercision()
        {
            var conn = new SQLiteConnection(path); // Соединение не закрываем, чтобы DataReader мог читать данные
            conn.Open();
            string selectQuery = @"SELECT te.id, te.sets, te.reps, te.weight, te.workLoad_percent, e.name, td.day_namber, w.Name as week_name
                                    FROM TraningExercision te
                                    JOIN Exercises e ON te.exercises_id = e.id
                                    JOIN TraningDay td ON te.traningDay_id = td.id
                                    JOIN Week w ON td.week_id = w.id; ";

            using (var selectCommand = new SQLiteCommand(selectQuery, conn))
            {
                return selectCommand.ExecuteReader(CommandBehavior.CloseConnection); // Закрываем соединение после чтения данных
            }


        }


    }
}
