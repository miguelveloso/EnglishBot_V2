using Telegram.Bot.Types.InputFiles;
using System;
using System.Threading.Tasks;
using Serilog;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;
using EnglishBots_V2.Structures;
using TelegramSink;

namespace EnglishBots_V2
{
    internal class Program
    {
        private static readonly TelegramBotClient Bot = new TelegramBotClient("111111111:AAaaaaaaaaaaaaaaaaaaaaddd");
  
        private static readonly ILogger _logger = new LoggerConfiguration()
                                                                           .WriteTo.Console()
                                                                           .WriteTo.RollingFile(pathFormat: "Log.log")
                                                                           .CreateLogger();
        private static readonly ILogger _logtelegram = new LoggerConfiguration()
                                                                                .MinimumLevel.Verbose()
                                                                                .WriteTo.TeleSink("222222222222:BBBBBBBBBBBBBBBBBBBBBBBBBBBBBB", "-12222222222211")
                                                                                .CreateLogger();
        
        private static void Main(string[] args)
        {
            _logger.Information("Program Started!");
            _logtelegram.Verbose("🚀Program Started!🚀 \n@mr_cor_bot\n @MrEnglishStudyBot");
            //Хэндлер сообщений
            Bot.OnMessage += Bot_OnMessage;
            _logger.Information("Starting Bot");
            _logtelegram.Verbose("❤️Bot has been started❤️");
            //_logtelegramgr.Information("Мы поднялись");
            Bot.StartReceiving();
            Console.ReadLine();
            //_logtelegramgr.Information("Бот остановился");
            Bot.StopReceiving();
            _logger.Warning("Stopping Bot");
            _logtelegram.Warning("Бот остановился");
        }
        private static async void Bot_OnMessage(object sender, global::Telegram.Bot.Args.MessageEventArgs e)
        {
            if (e.Message.Type == MessageType.Text)
            {
                var userId = e.Message.From.Id;
                var IsBot = e.Message.From.IsBot;
                var username = e.Message.From.Username;
                var firstName = e.Message.From.FirstName;
                var lastName = e.Message.From.LastName;

                _logger.Information($"От пользователя {firstName} {lastName}(t.me/{username} - {userId}) - признак бота:{IsBot} \n Получили сообщение: {e.Message.Text}");
                _logtelegram.Information($"От пользователя {firstName} {lastName}(t.me/{username} - {userId}) - признак бота:{IsBot} \n Получили сообщение: {e.Message.Text}");

                if (Statics.WordToEnumDictionary.ContainsKey(e.Message.Text.ToLower()))
                {
                    await HandleWord(e.Message.Chat.Id, userId, Statics.EnumToObjectDictionary[Statics.WordToEnumDictionary[e.Message.Text.ToLower()]]);
                    _logger.Information("Все отработало как надо из справочника слов");
                    _logtelegram.Information("Все отработало как надо из справочника слов");
                }
                else if (Operation.OperationToEnumDictionary.ContainsKey(e.Message.Text.ToLower()))
                {
                    await HandleComand(e.Message.Chat.Id, firstName, lastName, userId, Operation.EnumToObjectDictionary[Operation.OperationToEnumDictionary[e.Message.Text.ToLower()]]);
                    _logger.Information($"Ответили пользователю на запрос: {e.Message.Text.ToLower()}");
                    _logtelegram.Information($"Ответили пользователю на запрос: {e.Message.Text.ToLower()}");
                }
                else
                {
                    await Bot.SendStickerAsync(e.Message.Chat.Id, new InputOnlineFile("CAACAgIAAxkBAAIJgF6HP2XspGCeGDtAzBq5Pm4GR3QDAAIbAgACygMGC9wPPRAcg_U_GAQ"));
                    await Bot.SendTextMessageAsync(e.Message.Chat.Id, $"{firstName}, интересно, какой смысл вы вложили в это: {e.Message.Text.ToLower()}🙈");  //😢                    
                    _logger.Warning($"Сказали пользователю {firstName} {lastName} ({userId}) что не шарим слово: ►{e.Message.Text}◄, сори с уважением");
                    _logtelegram.Warning($"Сказали пользователю {firstName} {lastName} ({userId}) что не шарим слово: ►{e.Message.Text}◄, сори с уважением");
                }
            }
        }        

        private static async Task HandleComand(long chatId,
                                               string firstName,
                                               string lastName,
                                               int userId,
                                               Command command)
        {
            await Bot.SendTextMessageAsync(chatId, command.GetAnswers);
            _logger.Information($"Ответили пользователю {firstName} {lastName} ({userId})  в чате {chatId} сообщением: \n{command}");
            _logtelegram.Information($"Ответили пользователю {firstName} {lastName} ({userId})  в чате {chatId} сообщением: \n{command}");
        }

        private static async Task HandleWord(long chatId, int userId, Word word)
        {
            await Bot.SendTextMessageAsync(chatId, word.ToString());
            _logger.Information($"Ответили в чат {chatId} от пользователя {userId} на запрос пользователя: \n {word}");
            _logtelegram.Information($"Ответили в чат {chatId} от пользователя {userId} на запрос пользователя: \n {word}");
        }
    }
}
