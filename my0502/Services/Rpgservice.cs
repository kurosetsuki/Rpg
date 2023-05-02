namespace my0502.Services;

public class Rpgservice
{

    private static IList<Rpg> database;

    static Rpgservice()
    {
        database = new List<Rpg>();
        database.Add(new Rpg(){ id = 0, name = "boss", lv = 999 });
        database.Add(new Rpg(){ id = 1, name = "史萊姆", lv = 1 });
        database.Add(new Rpg(){ id = 2, name = "家門鳥", lv = 2 });
        database.Add(new Rpg(){ id = 3, name = "蟲", lv = 3 });
    }
    
    //Get/Read
    public Rpg Get(int id)
    {
        Rpg result = null;

        var db = from d in database
            where d.id == id
            select d;
        if (db.Any())
        {
            result = db.First();
        }

        return result;
    }
    
    
    //Post/Create
    public Rpg Create(Rpg rpg)
    {
        //Rpg result = null;

        rpg.id = database.Max(x => x.id) + 1; //修正id
        
        database.Add(rpg);

        return rpg;
    }
}