using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AspNetCoreWebAPIStarChart.Models;
using Microsoft.AspNetCore.Http;

namespace AspNetCoreWebAPIStarChart.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<CelestialObject> CelestialObjects { get; set; }
      

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

            if (!this.CelestialObjects.Any())
            {
                  //LoadStars();

          
            }
            
        }

        public void LoadStars()
        {
            // first planet add in memory
            String timespan = new TimeSpan(0, 0, 0, 0, 0).ToString();
            CelestialObject planetclestialObj1 = new CelestialObject();
            planetclestialObj1.Name = "Jupiter";
            planetclestialObj1.OrbitedObjectId = 0;
            planetclestialObj1.Satellites = new List<CelestialObject>();
            planetclestialObj1.OrbitalPeriod = timespan;
            this.CelestialObjects.Add(planetclestialObj1);

            this.SaveChanges();

            CelestialObject satellclestialObj1 = new CelestialObject();
            satellclestialObj1.Name = "Europa";
            satellclestialObj1.OrbitedObjectId = planetclestialObj1.Id;
            satellclestialObj1.Satellites = new List<CelestialObject>();
            satellclestialObj1.OrbitalPeriod = timespan;

            CelestialObject satellclestialObj2 = new CelestialObject();
            satellclestialObj2.Name = "Ganymede";
            satellclestialObj2.OrbitedObjectId = planetclestialObj1.Id;
            satellclestialObj2.Satellites = new List<CelestialObject>();
            satellclestialObj2.OrbitalPeriod = timespan;

            CelestialObject satellclestialObj3 = new CelestialObject();
            satellclestialObj3.Name = "Callisto";
            satellclestialObj3.OrbitedObjectId = planetclestialObj1.Id;
            satellclestialObj3.Satellites = new List<CelestialObject>();
            satellclestialObj3.OrbitalPeriod = timespan;


            this.CelestialObjects.Add(satellclestialObj1);
            this.CelestialObjects.Add(satellclestialObj2);
            this.CelestialObjects.Add(satellclestialObj3);

            this.SaveChanges();

            // second planet add

            CelestialObject planetclestialObj2 = new CelestialObject();
            planetclestialObj2.Name = "Earth";
            planetclestialObj2.OrbitedObjectId = 0;
            planetclestialObj2.Satellites = new List<CelestialObject>();
            planetclestialObj2.OrbitalPeriod = timespan;

            this.CelestialObjects.Add(planetclestialObj2);
            this.SaveChanges();

            CelestialObject satellclestialObj21 = new CelestialObject();
            satellclestialObj21.Name = "Moon";
            satellclestialObj21.OrbitedObjectId = planetclestialObj2.Id;
            satellclestialObj21.Satellites = new List<CelestialObject>();
            satellclestialObj21.OrbitalPeriod = timespan;

            this.CelestialObjects.Add(satellclestialObj21);
            this.SaveChanges();

            //third planet add
            CelestialObject planetclestialObj3 = new CelestialObject();
            planetclestialObj3.Name = "SATURN";
            planetclestialObj3.OrbitedObjectId = 0;
            planetclestialObj3.Satellites = new List<CelestialObject>();
            planetclestialObj3.OrbitalPeriod = timespan;

            this.CelestialObjects.Add(planetclestialObj3);
            this.SaveChanges();

            CelestialObject satellclestialObj31 = new CelestialObject();
            satellclestialObj31.Name = "Aegaeon";
            satellclestialObj31.OrbitedObjectId = planetclestialObj3.Id;
            satellclestialObj31.Satellites = new List<CelestialObject>();
            satellclestialObj31.OrbitalPeriod = timespan;

            CelestialObject satellclestialObj32 = new CelestialObject();
            satellclestialObj32.Name = "Aegir";
            satellclestialObj32.OrbitedObjectId = planetclestialObj3.Id;
            satellclestialObj32.Satellites = new List<CelestialObject>();
            satellclestialObj32.OrbitalPeriod = timespan;

            CelestialObject satellclestialObj33 = new CelestialObject();
            satellclestialObj33.Name = "Titan";
            satellclestialObj33.OrbitedObjectId = planetclestialObj3.Id;
            satellclestialObj33.Satellites = new List<CelestialObject>();
            satellclestialObj33.OrbitalPeriod = timespan;

          
            this.CelestialObjects.Add(satellclestialObj31);
            this.CelestialObjects.Add(satellclestialObj32);
            this.CelestialObjects.Add(satellclestialObj33);

            this.SaveChanges();


        }
        

    }
}
