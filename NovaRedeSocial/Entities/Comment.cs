

namespace NovaRedeSocial.Entities
{
    class Comment
    {
        public string Text { get; set; } //Texto

        public Comment() //Contrutor Padrão
        {
        }

        public Comment(string text)  //Contrutor com argumento
        {
            Text = text;
        }
    }

}
