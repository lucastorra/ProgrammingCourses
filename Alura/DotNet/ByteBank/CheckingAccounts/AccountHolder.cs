namespace ByteBank
{
    public class AccountHolder
    {
        private string _personID;

        public string Name { get; set; }
        public string PersonID
        {
            get
            {
                return _personID;
            }
            set
            {
                // Escrevo minha lógica de validação de PersonID
                _personID = value;
            }
        }
        public string Occupation { get; set; }
    }
}
