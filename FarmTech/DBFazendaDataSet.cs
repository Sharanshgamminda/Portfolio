using System.Data;

namespace FarmTech
{
    internal class DBFazendaDataSet
    {
        internal SchemaSerializationMode SchemaSerializationMode;

        public DBFazendaDataSet()
        {
        }

        public string DataSetName { get; internal set; }
    }
}