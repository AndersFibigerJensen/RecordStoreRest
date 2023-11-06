namespace RecordStoreRest.Controllers;

using Microsoft.AspNetCore.Mvc;
using Models;
using Repositories;

[Route("api/[controller]")]
[ApiController]
public class RecordController:ControllerBase
{


    private readonly RecordRepo Recordstore = new RecordRepo();

    [HttpGet]
    public List<Record> getrecords()
    {
        return Recordstore.GetRecords();
    }

    [HttpGet("{id}")]
    public Record? getrecord(int id)
    {
        return Recordstore.Getbyid(id);
    }

    [HttpDelete("{id}")]
    public Record? deleteRecord(int id)
    {
        return Recordstore.DeleteRecord(id);
    }

    [HttpPost]
    public Record PostRecord([FromBody] Record re)
    {
        return Recordstore.AddRecord(re);
    }

    [HttpPut("{id}")]
    public Record? UpdateRecord(int id, [FromBody] Record record) 
    {
        return Recordstore.UpdatedRecord(id, record);
    
    
    }
}
