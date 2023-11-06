using RecordStoreRest.Models;

namespace RecordStoreRest.Repositories
{
    public class RecordRepo
    {
        private List<Record> records = new();
        private int idcounter = 1;

        public RecordRepo()
        {
            records.Add(new Record { id=idcounter++,Title="to hell and back",Author="Sabaton",Price=100});
            records.Add(new Record { id = idcounter++, Title = "world war 2", Author = "Sabaton", Price = 100 });
            records.Add(new Record { id = idcounter++, Title = "for evigt", Author = "Volbeat", Price = 100 });
        }

        public Record AddRecord(Record reco)
        {
            reco.id=idcounter++;
            records.Add(reco);
            return reco;
        }

        public List<Record> GetRecords() 
        {
            return new List<Record>(records);
        }

        public Record? Getbyid(int id)
        {
            return records.FirstOrDefault(i=>i.id==id);
        }

        public Record? DeleteRecord(int id)
        {
            Record? ScratchedRecord = Getbyid(id);
            if(ScratchedRecord==null)
                return null;
            records.Remove(ScratchedRecord);
            return ScratchedRecord;
        }

        public Record? UpdatedRecord(int id,Record record)
        {
            Record? oldrecord = Getbyid(id);
            if (oldrecord == null)
                return null;
            oldrecord.Author= record.Author;
            oldrecord.Price = record.Price;
            oldrecord.Title = record.Title;
            return record;

        }
    }
}
