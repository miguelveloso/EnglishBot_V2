using EnglishBots_V2.Enum;
using Serilog;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnglishBots_V2.Structures
{
    public static class Operation
    {
        public static Dictionary<string, Commands> OperationToEnumDictionary = new Dictionary<string, Commands>
        {
            {"старт", Commands.start},
            {"start", Commands.start},
            {"/start", Commands.start},
            {"/start@mr_cor_bot", Commands.start},
            {"donate", Commands.donate },
            {"/donate", Commands.donate},
            {"payment", Commands.payment },
            {"/payment", Commands.payment },
            {"/about", Commands.about},
            {"/about@mr_cor_bot", Commands.about},
            {"/contact", Commands.contact},
            {"контакты", Commands.contact},
            {"/contact@mr_cor_bot", Commands.contact},
            {"собака", Commands.Dog},
            {"курс", Commands.currency},
            {"/currency", Commands.currency},
            {"/currency@mr_cor_bot", Commands.currency},
            {"/allwords", Commands.allwords},
            {"все слова", Commands.allwords},
            {"/allwords@mr_cor_bot", Commands.allwords},
            {"тренинг1", Commands.trainingfirst},
            {"/trainingfirst", Commands.trainingfirst},
            {"/trainingfirst@mr_cor_bot", Commands.trainingfirst},
            {"/trainingsecond", Commands.trainingsecond},
            {"тренинг2", Commands.trainingsecond},
            {"/trainingsecond@mr_cor_bot", Commands.trainingsecond},
            {"/getsubscribe", Commands.getsubscribe},
            {"подписки", Commands.getsubscribe},
            {"/getsubscribe@mr_cor_bot", Commands.getsubscribe},
            {"котик", Commands.kotik},
            {"helpmeplease", Commands.helpMe },
            {"/helpmeplease", Commands.helpMe },
            {"ping", Commands.ping},           
            /**/     
            
            {"сука", Commands.getmat}

        };
        

        public static Dictionary<Commands, Command> EnumToObjectDictionary = new Dictionary<Commands, Command>
        {

            {
            Commands.start, new Command
                {
                    GetAnswers = $"✨Привет, рад тебя видеть❗️ \n Можешь написать мне любой неправильный глагол в любой форме и я расскажу тебе о нем чуть чуть✨",
                }
            },
            {
                Commands.donate, new Command
                {
                    GetAnswers = "💰тут будет выбор суммы оплаты💰",
                }
            },
            {
                Commands.payment, new Command
                {
                    GetAnswers = "🤑тут будет оплата🤑",
                }
            },
            {
            Commands.about, new Command
             {
             GetAnswers = "❤️Компания 🐶Гав Гав🐶❤️ \n 🙈Мы уже миллион лет на рынке🙈\n 😻Можете поверить на слово что все будет красиво😻 \n"
             }
            },
            {
            Commands.contact, new Command
             {
              GetAnswers = "📩Почта для связи: sergey.krugluy1810@gmail.com📩 \n 📱Связь в telegram: t.me/miguelveloso📱 \n  📲Номер телефона: +380994322735📲"
             }
            },
            {
            Commands.Dog, new Command
             {
              GetAnswers = "🐶Сам собака🐶 \n"
             }
            },
            {
            Commands.currency, new Command
             {
              GetAnswers = "Курса нет \n"
             }
            },
            {
            Commands.allwords, new Command
             { //{firstName}
              GetAnswers = $"📜Можешь посмотреть все слова в таблице:📜 \n https://docs.google.com/spreadsheets/d/1dVbHig-WC-RtnhZRqtgGOqEBNbuA0jH4rXLKnwvX2Fo/edit#gid=642283759 "
             }
            },
            {
            Commands.trainingfirst, new Command
             {
              GetAnswers = "📹Посмотри обучающее видео:📹 \nhttps://www.youtube.com/watch?v=FEWrfgSGUu8&feature=emb_title \n"
             }
            },
            {
            Commands.trainingsecond, new Command
             {
              GetAnswers = "📹Посмотри обучающее видео:📹 \nhttps://www.youtube.com/watch?v=Dqb7xqyfTbg&feature=emb_title \n"
             }
            },
            {
            Commands.getsubscribe, new Command
             {
              GetAnswers = "🔺Если правила тебя выедают изнутри, рекомендую для обучения в более легком формате вот этот профиль instagram:🔻\n✨https://instagram.com/supreme.english ✨ \n 📹канал youtube:📹 \n 🔹https://goo-gl.su/rxTtHzdm 🔹 \n"
             }
            },
            {
            Commands.getmat, new Command
             {
              GetAnswers = "🔪Прошу Вас выбирать выражения, наш разговор записывается и мы Вас найдем!🔫 \n"
             }
            },
            {
                Commands.kotik, new Command
                {
                    GetAnswers = "😤Фу, не люблю котов 🐈\n✨Попробуй написать: Собака🐶✨"
                }
            },
            {
                Commands.helpMe, new Command
                {
                    GetAnswers = "✨Можешь помочь мне в заполнении таблицы слов и предложений по ссылке: https://docs.google.com/spreadsheets/d/1SJw7KQU0XWIxTs-e98VFw_JHmAReSJSlIKFjNoZdIHc/edit#gid=0 ✨"
                }
            },
            {
                Commands.ping, new Command
                {
                    GetAnswers = "win"
                }
            }

        };

    }
}