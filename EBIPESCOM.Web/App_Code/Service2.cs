using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Collections.Generic;
using System.Text;

[ServiceContract(Namespace = "")]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
public class Service2
{
	[OperationContract]
	public void DoWork()
	{
		// Add your operation implementation here
		return;
	}
    [OperationContract]
    public List<Budaya1> GetBudaya()
    {
        DataLINQDataContext db = new DataLINQDataContext();
        var mBudaya = from Budaya in db.Budaya1s
                      select Budaya;
        return mBudaya.ToList();
    }

    [OperationContract]
    public List<Anggota> Getanggota()
    {
        DataLINQDataContext db = new DataLINQDataContext();
        var manggota = from anggota in db.Anggotas
                       select anggota;
        return manggota.ToList();
    }

    [OperationContract]
    public List<Galeri> Getgaleri()
    {
        DataLINQDataContext db = new DataLINQDataContext();
        var mgaleri = from galeri in db.Galeris
                      select galeri;
        return mgaleri.ToList();
    }

    [OperationContract]
    public List<Provinsi1> Getprovinsi()
    {
        DataLINQDataContext db = new DataLINQDataContext();
        var mprovinsi = from provinsi in db.Provinsi1s
                        select provinsi;
        return mprovinsi.ToList();
    }
	// Add more operations here and mark them with [OperationContract]
}
