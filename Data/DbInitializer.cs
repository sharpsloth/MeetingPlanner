using MeetingPlanner.Data;
using MeetingPlanner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingPlanner.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SacramentContext context)
        {
            context.Database.EnsureCreated();

            // Look for any planners
            if (context.Planners.Any())
            {
                return; // DB has already been seeded
            }

            var planners = new Planner[]
            {
                new Planner
                {
                    MeetingDate=DateTime.Parse("2020-05-24"),
                    Conducting="Byron Lee",
                    OpeningSong="Now Let Us Rejoice",
                    SacramentHymn="There is a Green Hill Far Away",
                    ClosingSong="God Be With You",
                    IntermediateMusic="A Child's Prayer",
                    OpeningPrayer="Tommy Mendenhall",
                    ClosingPrayer="Sara Sites"
                },
                new Planner
                {
                    MeetingDate=DateTime.Parse("2020-05-31"),
                    Conducting="Sam North",
                    OpeningSong="Lead, Kindly Light",
                    SacramentHymn="Testimony",
                    ClosingSong="Sing We Now at Parting",
                    IntermediateMusic="I am a Child of God",
                    OpeningPrayer="Rebecca Wright",
                    ClosingPrayer="Lauren Call"
                },
                new Planner
                {
                    MeetingDate=DateTime.Parse("2020-06-07"),
                    Conducting="Tony Mendenhall",
                    OpeningSong="Come, Come Ye Saints",
                    SacramentHymn="More Holiness Give Me",
                    ClosingSong="Oh, Say What is True",
                    IntermediateMusic="Gethsemane",
                    OpeningPrayer="Regina Hinckley",
                    ClosingPrayer="Roger Wiblin"
                },
                new Planner
                {
                    MeetingDate=DateTime.Parse("2020-06-14"),
                    Conducting="Byron Lee",
                    OpeningSong="The Voice of God Again is Heard",
                    SacramentHymn="The Morning Breaks",
                    ClosingSong="Truth Eternal",
                    IntermediateMusic="High on the Mountain Top",
                    OpeningPrayer="Dorj Badam",
                    ClosingPrayer="Jordyn Gebs"
                },
                new Planner
                {
                    MeetingDate=DateTime.Parse("2020-06-21"),
                    Conducting="Sam North",
                    OpeningSong="Redeemer of Israel",
                    SacramentHymn="Israel, Israel, God is Calling",
                    ClosingSong="Awake and Arise",
                    IntermediateMusic="Come, Rejoice",
                    OpeningPrayer="Michael Owen",
                    ClosingPrayer="Sarah Tyre"
                },
                new Planner
                {
                    MeetingDate=DateTime.Parse("2020-06-28"),
                    Conducting="Tony Mendenhall",
                    OpeningSong="Come, Sing to the Lord",
                    SacramentHymn="What Was Witnessed in the Heavens",
                    ClosingSong="'Twas Witnessed in the Morning Sky",
                    IntermediateMusic="An Angel from on High",
                    OpeningPrayer="Greg Snowden",
                    ClosingPrayer="Abby Lopresti"
                },
                new Planner
                {
                    MeetingDate=DateTime.Parse("2020-07-05"),
                    Conducting="Byron Lee",
                    OpeningSong="Sweet Is the Peace the Gospel Brings",
                    SacramentHymn="I Saw a Mighty Angel Fly",
                    ClosingSong="What Glorious Scenes mine Eyes Behold",
                    IntermediateMusic="Awake, Ye Saints of God, Awake!",
                    OpeningPrayer="Megan Embody",
                    ClosingPrayer="Bart Brown"
                } };
            context.Planners.AddRange(planners);
            context.SaveChanges();

            var talks = new Talk[]
            {
                new Talk{PlannerID=1,Speaker="Tony Mendenhall",Topic="Faith"},
                new Talk{PlannerID=1,Speaker="Bart Brown",Topic="Faith"},
                new Talk{PlannerID=1,Speaker="Phil Holt",Topic="Faith"},
                new Talk{PlannerID=2,Speaker="Tammy Baker",Topic="Hope"},
                new Talk{PlannerID=2,Speaker="Elizabeth Peterson",Topic="Hope"},
                new Talk{PlannerID=3,Speaker="William Hansen",Topic="Charity"},
                new Talk{PlannerID=3,Speaker="Macie Greene",Topic="Charity"},
                new Talk{PlannerID=3,Speaker="Jerry Zazzie",Topic="Charity"},
                new Talk{PlannerID=5,Speaker="Eleanor Barlow",Topic="Enduring Trials"},
                new Talk{PlannerID=5,Speaker="Erica Wilde",Topic="Enduring Trials"},
                new Talk{PlannerID=5,Speaker="Bruna Laurenco",Topic="Enduring Trials"},
                new Talk{PlannerID=6,Speaker="Ralph Knox",Topic="Service"},
                new Talk{PlannerID=6,Speaker="Claire Phillips",Topic="Service"},
                new Talk{PlannerID=7,Speaker="Heather Smallwood",Topic="Forgiveness"},
                new Talk{PlannerID=7,Speaker="Frank Butler",Topic="Forgiveness"},
                new Talk{PlannerID=7,Speaker="Nancy Brown",Topic="Forgiveness"}
            };

            context.Talks.AddRange(talks);
            context.SaveChanges();
        }
    }
}
