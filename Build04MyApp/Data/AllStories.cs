using Build04MyApp.Models;

namespace Build04MyApp.Data
{
    public class AllStories
    {
        public enum Genre {
            adventure,
            fantasy,
            fiction,
            sci_fi,
               love,
           short_stories,
                suspense,
            memoir,
            poerty,
            motivation,
                ture_story,
                critic,
                self_love

        }

        public List<Story> getAllStories()
        {
            List<Story> stories = new List<Story>();
            
            string quote01 = "the platforms of the railway station is a small world moving through the rapidly evolving larger world, having its own life, rhythm and story to tell.";
            string shortDes01 = "The Platform of the railway station and I have this perplexing yet beautiful relationship.  I have the faintest memory of my first...";
            string description01 = @"The Platform of the railway station and I have this perplexing yet beautiful relationship. I have the faintest memory of my first long and arduous train journey from the temple city of Tamil Nadu to the land of five rivers.  My mom recalls how I ""bounce off the wall"", whenever I hear the ""Chuff Chuff"" of the formidable engine. 
Being an ""Army child"" whose father gets posted repeatedly across the length and breadth of the country; I had an opportunity to explore several railway stations. I have seen the platform of Punjab, an epitome of cleanliness, and also seen the filthiest station in Uttar Pradesh. I have seen exhausting hot station of Rajasthan and also seen chilled-to-the-bone cold platforms of Jammu. 
Sometimes, even on these days during weekends, I simply pack my bag and bustle to nearby railway station, only to sit on those concrete benches, aimlessly staring at the zipping world which stops for nothing. 
The fast-moving world unfolding in front of my eye reminds me how transient our days are, and how life is a sojourn on the planet. 

The formidable large locomotive is an archetype of how one must be strong and keep moving forward through the storm and through the dark tunnels with no hesitation. 

The scene of a bewildered child clinging to his mother's arm out of ""fear of missing out"" in the throng, helps me to realize that though I am an adult now, I still yearn for my mother's arm when going gets tough. 

A tryst between the oblivious young couple on the warm lit bench at the corner, reminds me how romanticism helps us to forget the strife-ridden world around us and emancipate one into their own fairyland. 

The scene of a man struggling to walk with a baggage of load around his back is a reminder of how emotional baggage wanes us down and time has come to lay it down and leave behind all the struggling and striving. 

The scene of a rag-picker with his eclectic collections of rags reiterates that little things are infinitely, the most important, and a reminder to value my belongings. 

The sporadically loud voice from the announcement speaker, which feels like an authoritative order straight from heaven, guiding all the lost ones, propounds the existence of a God. 

In a way, the platform epitomizes a perfect egalitarian world. Here, there is no stratification based on religion, gender, or caste. Everyone enjoys the same rights. We board the train from the platform together and we get down together. An affluent has to wait for the train, and so does the poor.  Rich has to sit on the same concrete bench and so does the poor. A vegan eats the same food as the meatarian. 

In fact, the platforms of the railway station is a small world moving through the rapidly evolving larger world, having its own life, rhythm and story to tell.";

            string quote02 = "There are people suffering, so if you care enough for living, then be like \"The man who listened\"";
            string shortDes02 = "Studying space has always been my interest since time immemorial.  It is out of this interest that I made up my mind to make a visit to BM Birla planetarium...";
            string description02 = @"Studying space has always been my interest since time immemorial.  It is out of this interest that I made up my mind to make a visit to BM Birla planetarium.  I started early and my excitement buttressed when I found myself at the imposing gate of the planetarium.  The receptionist was a benign lady and besides giving me my ticket she helped me to set my agenda right.

As per the agenda, my first go-to-place was the Planetarium Dome theater where the show was scheduled for 11:30. But to my surprise, I found a long serpentine queue of primary children bogged up with colorful backpacks. I took my spot. I scanned up and down the line and was imbued by these oblivious kids. Unlike all the adults who were expeditiously scrolling the screen of their digital device, these kids were laughing, cuddling and talking with each other. What a strange behavior in the world of digital echo-chamber?. I eavesdropped on the conversation between two kids, one of whom was bragging about his Spiderman water bottle.

I tried to intervene and show my Avengers water bottle, which is far more dope than his, but I chose to remain modest. Time was half past one and after the mind-boggling show everyone retired to have their lunch. I was wandering to find a perfect place to have my luncheon, which was packed by my dear friend for this little adventure. For some reason I chose to go to Evolution Park. The park was a ""little gift of forest"". Its verdure green pavement opened the door to the utopian world. I took a seat on the precast concrete bench, which was placed facing the sculpture from Jurassic and Cretaceous Period.
Other than a Tyrannosaurus Rex, who was staring right into my soul, I was pretty much alone, which gave me much needed privacy to enjoy my delicacy.

The time was little past two that my unfettered privacy was shunned by a conspicuous man whose eyes were vetted on the imposing Ovi-raptor. ""Was he there this whole time?"", I questioned myself. Few minutes had passed and the man was still there, barely moved an inch, meticulously scanning the Ovi-raptor.  I went curious and trudged towards him for a little chat. I stood next to him and said, ""Ahh!! Ovi-raptor, a few omnivore dinosaurs"".  I was expecting a good response for my dinosaur-knowledge, but he reciprocated with a wordless smile.
""It's hard to believe that this gigantic creature roamed this land a few eons before"", I continued.  Still, he kept smiling with his eye dovetailed on the Ovi-raptor. I posited, ""It was an amazing show, wasn't? I almost lost it when we zipped through Saturn rings, it was surreal"".  He kept smiling. 
Over the next quarter way around the clock, I spoke about varied topics such as Black Hole, supernova, war etc. and all the while he was smiling. I would easily be a victim of prejudice if I were to talk on a similar topic with someone else, but here is a man who listened without any contention. Before I left, I requested a selfie for which he graciously smiled and we took a nice snap.

On the way back, I realized that I didn't ask for his name. All I know is that he is ""The man who listened"".
If only more people were like him, half of modern-day problems would be solved. I have seen a long term relationship break-away just because people stop listening. I see best friends who shared the bonhomie for a decade, losing it because they lost the patience to listen. I see people dying as the government stops listening. I have seen countries declare war because no one was listening.

There are people suffering, so if you care enough for living, then be like ""The man who listened"".  

PS: The man said in this story is a person from Neanderthal, an extinct human species.  Yes, it's a statue to whom I was talking to:-) ";

            string quote03 = " The warmth on the handrail where she leaned and an anecdote is what's left.";
            string shortDes03 = "The temperature on my phone read 26 degrees, something which happens rarely at the place where mercury ascends to 42 on normal days...";
            string description03 = @"The temperature on my phone read 26 degrees, something which happens rarely at the place where mercury ascends to 42 on normal days. I was en route home after spending the weekend at my brothers'. I reached Central metro, which gave a deserted look late in the evening.

At the streets, the LCD read 2 mins for next the metro.  I boarded the metro on the purple line and inside it was fairly empty.  I sat next to door so as to watch the little blinking light on the map above, tracing the route.  Door closed with a beeping sound and my lazy body skewed to other side as the train picked up momentum, watching the fast moving city lit up by warm ochre orange through foggy glasses. I was just in the middle of Hallow Coves melancholy song that train came to a grinding halt at the next station.  With the warning light turning green, door slides open to welcome new commuters.

And then I saw her, an archetype of beautifulness,  entering. The empty, dimly-lit bogie suddenly filled with luminance as the train ascended into the sky, leaving the darkness of the underground behind. Her accentuating eyes behind the gray mask opened a door to a different world of utopia.  The train was empty but still she chose to stand next to the chilling handrails, doomscrolling her screen which was perfectly held in her little fingers with the nails adorned with shimmery matte black.  I was struck in the vortex of emotion with my hippocampus shooting all kinds of signals, badgering me to go and talk to her.  I thought of writing a note eulogizing my emotion with all the lexicon I knew and giving it to her, but this kind of communication relic is long lost in the world of instant messages, so I jettisoned the thought.  I knew time was running fast and it's already been 4 stops now since the time. 

Finally, I gleaned my courage, stood up, the fear in my face was germane.  I trudged away from the seat and nimble-footed towards her and then the door of disappointment threw open.  The warning sign turned green and she swiftly landed on the platform.  I stood ice-still reckoning what just happened.  The warning sign changed its color again and I saw her footing towards the exit through the narrow gap of the closing door.  She was gone.  

I retired to my seat again, broken-hearted. The light was blinking one stop away from my destination. The fact that I would never see this girl again was eating me alive.  The warmth on the handrail where she leaned and an anecdote is what's left.";

            string quote04 = "the attack which cannot be tolerated any further and give \"peace a chance\"";
            string shortDes04 = "My dear roomie, how are you? My warm wishes to the ant-cohort. I Am writing this to bring your attention to the recent unprovoked...";
            string description04 = @"My dear roomie, how are you? My warm wishes to the ant-cohort. I Am writing this to bring your attention to the recent unprovoked and unjustified attack by your army of ants on my cheese-cake. 
Albeit, the verbal consensus which we reached in the wake of a similar event last week on my hide-and-seek biscuit, the incessant attack by your army is saddening. 

And it is egregious that under the Armed Force Special Power act (AFSPA), your army is immune from legal action for trespassing and causing damage on the peaceful, tasty and civil-establishment (my cheese-cake), just like how Indian govt use the same AFSPA in Nagaland and Mizoram to curb the opposition for political gain. 
Also terming the recent attack on my cake as a special military operation to provide food and security for the hungry ant population does not augur-well, though similar rhetoric was used by Russian President Vladimir Putin to justify the on-going war.  

I tried speaking to some of your ant-soldiers who were marching in a perfect straight line with a small piece of cake twice their size to ceasefire, but all my pleas fell on deaf ears, just like how some politicians are vis a vis peoples demand. I think it's safe to say that the strike on my cake is revenge for killing your bigwig 2 days back.
But with veneration, what happened on that fateful day was an accident.  

I feel great remorse for stepping on one of your ant who died on the spot. And it's sad that you had to carry the dead ant on your shoulder without an ambulance, but we humans are not so different. Last week in Tirupati, a father had to carry his 7-year-old son, who died of liver disease, on his shoulder as the hospital charged 20000 for an ambulance which he could not afford as he works in an orchard and earns 4000 a month.  

So, I am writing this to condemn the attack which cannot be tolerated any further and give ""peace a chance"". ";

            string quote05 = "remind yourself that you matter.";
            string shortDes05 = "The weekends are the best part of the week. I woke up later than usual. The mellow morning greeted me with warm vermilion...";
            string description05 = @"The weekends are the best part of the week. I woke up later than usual. The mellow morning greeted me with warm vermilion sunlight which kicked-off my urge for brew. I dived into a kitchenette to hunt recently bought liquid decoction. With a piping hot coffee and Dean Lewis' mellifluous music on play, I sticked with the routine of reading the newspaper. 

I turned straight into world news where the headline read ""Russian strike killed 6 including a 2 month old baby"". Yes, a 2-month-old baby. Suddenly dark clouds surrounded all over and I went dystopian. Here we are enjoying our weekends and somewhere in the hellfire of battle ground are these people who are trying hard just to stay alive with a fading hope to see the end of this inexorable war. 

Reader's please don't curse me for spoiling your good weekend mood with the dark happenings of the world. All I emphasize is that the freedom which we are enjoying now is not eternal. The unconsciousness war between Ukraine and Russia is a reminder that war is inevitable in the political world. The brute killing in the state of Bucha is a reminder of how cruel humans can be. 

The economic turmoil in Srilanka is a reminder that your savings render useless if the economy crashes due to invisible market forces. The political drama in Pakistan is a reminder that the leader who we believe will steer us through tough roads may fall overnight. 

So this writing is a reminder that the future is uncertain, so live the present to the fullest. Spread fraternity and speak the language of love. Remind your closer ones how much you love them, remind your friends that they are magical. And finally remind yourself that you matter.";

            stories.Add(new Story(1, "The platform", description01, "assets/images/myimage01.png", shortDes01, quote01,Genre.ture_story));
            stories.Add(new Story(2, "The man who listened", description02, "assets/images/myimage02.png", shortDes02, quote02,Genre.fantasy));
            stories.Add(new Story(3, "The girl at the metro", description03, "assets/images/myimage03.png", shortDes03, quote03,Genre.love));
            stories.Add(new Story(4, "The ant king", description04, "assets/images/myimage04.png", shortDes04, quote04,Genre.critic));
            stories.Add(new Story(5, "Remind yourself", description05, "assets/images/myimage05.png", shortDes05, quote05,Genre.self_love));

            return stories;

        }


    }
}
