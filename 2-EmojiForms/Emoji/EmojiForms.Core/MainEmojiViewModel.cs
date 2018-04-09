using System;
using System.ComponentModel;
using Xamarin.Forms;
using System.Windows.Input;
using System.Threading.Tasks;
namespace EmojiForms.Core
{
    public class MainEmojiViewModel : INotifyPropertyChanged
    {
        public MainEmojiViewModel()
        {
            GetEmojiCommand = new Command(async () => await ExecuteGetEmoji());
        }

        public ICommand GetEmojiCommand { get; }

        async Task ExecuteGetEmoji()
        {
            var emojiService = new EmojiService();

            if (string.IsNullOrEmpty(Sentence))
            {
                var info = await emojiService.GetEmoji();
                EmojiText = info.Emoji;
            }
            else
            {
                var result = await emojiService.GetSentiment(Sentence);

                EmojiText = $"{result.LanguageCountry} {result.Feeling}";
            }
        }

        string _emojiText;
        public string EmojiText
        {
            get => _emojiText;
            set
            {
                if (_emojiText == value)
                    return;

                _emojiText = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(EmojiText)));
            }
        }

        public string _sentence;
        public string Sentence
        {
            get => _sentence;
            set
            {
                if (_sentence == value)
                    return;

                _sentence = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Sentence)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
