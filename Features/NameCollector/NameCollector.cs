namespace NetCoreWorkshop_04_20_18.Features.NameCollector
{
    public class NameCollector
    {
        private string[] names = new string[3];
        public NameCollector()
        {
            names[0] = "Steve";
            names[1] = "Abby";
            names[2] = "Luke";
        }

        public void AddName(string newName){
            names[names.Length] = newName;
        }

        public void RemoveName(string nameToRemove){
            var i = 1;
            do {
                if (names.GetValue(i).ToString() == nameToRemove){
                    names[i] = null;
                }
            } while(i <= names.Length);
        }

        public string[] GetNames(){
            return names;
        }
    }
}