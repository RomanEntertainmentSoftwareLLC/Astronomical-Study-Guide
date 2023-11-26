using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astronomical_Study_Guide
{
    class Chapter7
    {
        public enum QuestionType
        {
            MultipleChoice = 0,
            TrueOrFalse = 1
        };

        public int questionsInGame;
        private int numberOfQuestions;
        private int numberOfAnswers;
        public int minutes;
        public int seconds;
        private string[] question;
        public string[,] answer;
        public bool[] mastered;
        private int[] order;
        public int[] randomOrder;
        public int score;
        public int antiScore;
        public int questionNumber;
        public string text;
        public string yourAnswer;
        public QuestionType[] questiontype;

        private void Setup_Questions()
        {
            numberOfQuestions = 83;
            numberOfAnswers = 4;
            question = new string[numberOfQuestions];
            answer = new string[numberOfQuestions, numberOfAnswers];
            questiontype = new QuestionType[numberOfQuestions];
            mastered = new bool[numberOfQuestions];

            question[0] = "Which of the following layers of a planet is not characterized by its density?"; answer[0, 0] = "Lithosphere."; answer[0, 1] = "Core."; answer[0, 2] = "Mantle."; answer[0, 3] = "Crust."; questiontype[0] = QuestionType.MultipleChoice;
            question[1] = "As a planet cools, what happens to its lithosphere?"; answer[1, 0] = "It gets thicker."; answer[1, 1] = "Nothing, except getting colder too."; answer[1, 2] = "It gets thinner."; answer[1, 3] = "It rises to the surface of the planet."; questiontype[1] = QuestionType.MultipleChoice;
            question[2] = "Where in Earth is conduction the most important heat transport process?"; answer[2, 0] = "In the lithosphere."; answer[2, 1] = "In the core."; answer[2, 2] = "In the mantle."; answer[2, 3] = "In the crust."; questiontype[2] = QuestionType.MultipleChoice;
            question[3] = "What role does a planet's size play in its geological activity?"; answer[3, 0] = "Larger planets are more geologically active because " + Environment.NewLine +
                "they take longer to cool off."; answer[3, 1] = "Larger planets are more geologically active because they have thicker lithospheres."; answer[3, 2] = "Larger planets are less geologically active because they " + Environment.NewLine +
                "have thicker lithospheres."; answer[3, 3] = "Larger planets are less geologically active because they have " + Environment.NewLine +
                "larger surface areas to radiate heat away."; questiontype[3] = QuestionType.MultipleChoice;
            question[4] = "Which of the following is not needed for a planet to have a global magnetic field?"; answer[4, 0] = "A thick electrically conducting lithosphere."; answer[4, 1] = "An electrically conducting fluid in the interior."; answer[4, 2] = "Convection in the conducting fluid."; answer[4, 3] = "Moderately rapid rotation."; questiontype[4] = QuestionType.MultipleChoice;
            question[5] = "Which planetary properties control erosion?"; answer[5, 0] = "All of the above."; answer[5, 1] = "Size."; answer[5, 2] = "Rotation rate."; answer[5, 3] = "Distance from the Sun."; questiontype[5] = QuestionType.MultipleChoice;
            question[6] = "Which of the following geological processes is most evident on the surface of a " + Environment.NewLine +
                "small planet?"; answer[6, 0] = "Impact cratering."; answer[6, 1] = "Erosion."; answer[6, 2] = "Volcanism."; answer[6, 3] = "Tectonics."; questiontype[6] = QuestionType.MultipleChoice;
            question[7] = "The geological age of a planet's surface can be determined from the relative " + Environment.NewLine +
                "amount of"; answer[7, 0] = "impact craters."; answer[7, 1] = "erosion features."; answer[7, 2] = "volcanic features."; answer[7, 3] = "tectonic features."; questiontype[7] = QuestionType.MultipleChoice;
            question[8] = "Why are the lunar maria smooth?"; answer[8, 0] = "They formed after the heavy bombardment and therefore have fewer craters and " + Environment.NewLine +
                "the lava that formed the maria lacked gases and was therefore thin and runny."; answer[8, 1] = "They formed after the heavy bombardment and therefore have fewer craters."; answer[8, 2] = "The lava that formed the maria lacked gases and was " + Environment.NewLine +
                "therefore thin and runny."; answer[8, 3] = "Bombardment of the Moon by meteoroids smoothed " + Environment.NewLine +
                "over any original rough features in the maria."; questiontype[8] = QuestionType.MultipleChoice;
            question[9] = "Why does Mercury have large cliffs?"; answer[9, 0] = "They were produced when the interior cooled and " + Environment.NewLine +
                "the entire planet shrank."; answer[9, 1] = "They were produced by plate tectonics, much like cliffs " + Environment.NewLine +
                "on Earth."; answer[9, 2] = "They were produced by the stress of a large upwelling " +
                "on one side of the planet that produced a bulge with " + Environment.NewLine +
                "canyons and cliffs."; answer[9, 3] = "The cliffs are the rims of large impact basins."; questiontype[9] = QuestionType.MultipleChoice;
            question[10] = "Who popularized the idea that there was a network of canals on Mars which carried water " + Environment.NewLine +
                "from the polar ice caps?"; answer[10, 0] = "Percival Lowell."; answer[10, 1] = "Giovanni Schiaparelli."; answer[10, 2] = "William Herschel."; answer[10, 3] = "H. G. Wells."; questiontype[10] = QuestionType.MultipleChoice;
            question[11] = "Which of the following is not a similarity between Mars and Earth today?"; answer[11, 0] = "They both have rivers."; answer[11, 1] = "The lengths of their days are similar."; answer[11, 2] = "They both have polar ice caps."; answer[11, 3] = "They have similar amounts of land."; questiontype[11] = QuestionType.MultipleChoice;
            question[12] = "Which of the following geological processes is currently active on Mars?"; answer[12, 0] = "Impact cratering."; answer[12, 1] = "Volcansim."; answer[12, 2] = "Tectonics."; answer[12, 3] = "All of the above."; questiontype[12] = QuestionType.MultipleChoice;
            question[13] = "Which of the following is not evidence that has been found for liquid water " + Environment.NewLine +
                "on Mars's surface in the past?"; answer[13, 0] = "None of the above (all are evidence of past water)."; answer[13, 1] = "Ancient riverbeds."; answer[13, 2] = "Layered deposits similar to sedimentary rocks."; answer[13, 3] = "The presence of iron-bearing spheres called blueberries that form in water."; questiontype[13] = QuestionType.MultipleChoice;
            question[14] = "The distribution of craters on the surface of Venus suggests that "; answer[14, 0] = "the entire planet was resurfaced about 750 million years ago."; answer[14, 1] = "its surface is ancient and has not been altered by volcanism, " + Environment.NewLine +
                "erosion or tectonics since the time of the heavy bombardment."; answer[14, 2] = "parts of the surface are ancient, while others have been " + Environment.NewLine +
                "resurfaced within the last 100 million years."; answer[14, 3] = "there has been ongoing regional resurfacing leading to a " + Environment.NewLine +
                "distribution of surface ages between about 100 million years " + Environment.NewLine +
                "and 750 million years."; questiontype[14] = QuestionType.MultipleChoice;
            question[15] = "What feature of Venusian geology is largely unexplained?"; answer[15, 0] = "It lacks plate tectonics."; answer[15, 1] = "It lacks substantial erosion."; answer[15, 2] = "It has few impact craters."; answer[15, 3] = "None of the above; we understand each of these features."; questiontype[15] = QuestionType.MultipleChoice;
            question[16] = "Which of the following is not evidence of plate tectonics on Earth?"; answer[16, 0] = "Tidal forces from the Moon and Sun are strong enough to " + Environment.NewLine +
                "cause continental drift."; answer[16, 1] = "There are fossils of similar species on widely separated continents."; answer[16, 2] = "Seafloor crust is much younger than continental crust."; answer[16, 3] = "Mid-ocean ridges are sites of mantle material eruption and " + Environment.NewLine +
                "seafloor spreading."; questiontype[16] = QuestionType.MultipleChoice;
            question[17] = "Plumes of hot mantle material are responsible for "; answer[17, 0] = "the formation of the Hawaiian Islands and the geysers of Yellowstone National Park."; answer[17, 1] = "the formation of the Hawaiian Islands."; answer[17, 2] = "the geysers of Yellowstone National Park."; answer[17, 3] = "the Appalachian mountains."; questiontype[17] = QuestionType.MultipleChoice;
            question[18] = "Why does Earth have the youngest surface of all the terrestrial planets today?"; answer[18, 0] = "All of the above."; answer[18, 1] = "It is the largest terrestrial planet so its interior has " + Environment.NewLine +
                "not cooled too much."; answer[18, 2] = "It is not so close to the Sun that it has lost its water " + Environment.NewLine +
                "and developed a thick lithosphere."; answer[18, 3] = "It rotates rapidly."; questiontype[18] = QuestionType.MultipleChoice;
            question[19] = "Which lists the planets in order of increasing atmospheric surface pressure?"; answer[19, 0] = "Mars, Earth, Venus"; answer[19, 1] = "Mars, Venus, Earth"; answer[19, 2] = "Earth, Venus, Mars"; answer[19, 3] = "Earth, Mars, Venus"; questiontype[19] = QuestionType.MultipleChoice;
            question[20] = "Why does atmospheric pressure decrease with altitude?"; answer[20, 0] = "The weight of the atmosphere above decreases as altitude increases."; answer[20, 1] = "The temperature of the atmosphere decreases."; answer[20, 2] = "The temperature of the atmosphere increases."; answer[20, 3] = "The molecules in the upper atmosphere are lighter."; questiontype[20] = QuestionType.MultipleChoice;
            question[21] = "How does the greenhouse effect work?"; answer[21, 0] = "Greenhouse gases absorb thermal radiation that is emitted by the surface."; answer[21, 1] = "Greenhouse gases reflect light that reflects off the surface back toward the surface."; answer[21, 2] = "Greenhouse gases absorb light that reflects off the surface."; answer[21, 3] = "Greenhouse gases reflect thermal radiation that is emitted by the surface."; questiontype[21] = QuestionType.MultipleChoice;
            question[22] = "Which of the following is not a greenhouse gas?"; answer[22, 0] = "Ozone (O3)."; answer[22, 1] = "Water vapor (H2O)."; answer[22, 2] = "Carbon dioxide (CO2)."; answer[22, 3] = "Methane (CH4)."; questiontype[22] = QuestionType.MultipleChoice;
            question[23] = "Why is the sky blue?"; answer[23, 0] = "Air molecules scatter blue light more than they scatter red light."; answer[23, 1] = "Air molecules absorb red light and reflect blue light."; answer[23, 2] = "Air molecules absorb all wavelengths of light and emit blue light."; answer[23, 3] = "The atmosphere is reflecting the blue color of the oceans."; questiontype[23] = QuestionType.MultipleChoice;
            question[24] = "Which of the following is not a factor in producing long-term climate change?"; answer[24, 0] = "The distances of the planets from the Sun slowly change."; answer[24, 1] = "The brightness of the Sun slowly changes."; answer[24, 2] = "The axis tilts of planets slowly change."; answer[24, 3] = "The abundance of greenhouse gas in the atmosphere changes."; questiontype[24] = QuestionType.MultipleChoice;
            question[25] = "What is the primary source of gas for thick terrestrial planet atmospheres?"; answer[25, 0] = "Volcanic outgassing."; answer[25, 1] = "Evaporation and sublimation from surface ices and liquids."; answer[25, 2] = "Impacts on the surface by the solar wind."; answer[25, 3] = "Meteoroid impacts on the surface."; questiontype[25] = QuestionType.MultipleChoice;
            question[26] = "Which of the following increases atmospheric loss by thermal escape?"; answer[26, 0] = "Increasing the temperature of the atmosphere."; answer[26, 1] = "Increasing the mass of the gas particles."; answer[26, 2] = "Increasing the escape velocity of the planet."; answer[26, 3] = "All of the above."; questiontype[26] = QuestionType.MultipleChoice;
            question[27] = "What is the source of the exospheres of the Moon and Mercury?"; answer[27, 0] = "impacts on the surface by solar wind particles and meteoroid impacts on the surface."; answer[27, 1] = "Impacts on the surface by solar wind particles."; answer[27, 2] = "Meteoroid impacts on the surface."; answer[27, 3] = "Volcanic outgassing."; questiontype[27] = QuestionType.MultipleChoice;
            question[28] = "How do seasons on Mars differ from seasons on Earth?"; answer[28, 0] = "They are more extreme because of Mars's larger orbital eccentricity."; answer[28, 1] = "They are less extreme because of Mars's smaller axis tilt."; answer[28, 2] = "They are more extreme because of Mars's greater axis tilt."; answer[28, 3] = "They are less extreme because of Mars's larger orbit."; questiontype[28] = QuestionType.MultipleChoice;
            question[29] = "If all the ice in Mars's polar caps were melted, how deep an ocean would it make?"; answer[29, 0] = "About 10 meters."; answer[29, 1] = "About 1 meter."; answer[29, 2] = "About 100 meters."; answer[29, 3] = "About 1000 meters."; questiontype[29] = QuestionType.MultipleChoice;
            question[30] = "How does a magnetosphere affect a terrestrial planet atmosphere?"; answer[30, 0] = "It protects the upper atmosphere from the solar wind."; answer[30, 1] = "It protects the upper atmosphere from X-rays."; answer[30, 2] = "It redistributes energy from the poles to the equator."; answer[30, 3] = "It has no effect on the atmosphere."; questiontype[30] = QuestionType.MultipleChoice;
            question[31] = "Why did Mars lose most of its atmosphere?"; answer[31, 0] = "All of the above."; answer[31, 1] = "Its atmosphere condensed onto the poles and froze into " + Environment.NewLine +
                "the soil because Mars is farther from the Sun."; answer[31, 2] = "It lost its atmosphere to space after losing its magnetic field."; answer[31, 3] = "Its small size prevented it from holding onto its atmosphere."; questiontype[31] = QuestionType.MultipleChoice;
            question[32] = "What is the primary constituent of Venus's atmosphere?"; answer[32, 0] = "Carbon dioxide (CO2)."; answer[32, 1] = "Carbon monoxide (CO)."; answer[32, 2] = "Nitrogen (N2)."; answer[32, 3] = "Oxygen (O2)."; questiontype[32] = QuestionType.MultipleChoice;
            question[33] = "Which of the following did not contribute to Venus's runaway greenhouse effect?"; answer[33, 0] = "Due to its slow rotation, its magnetic field failed to " + Environment.NewLine +
                "prevent heating of the atmosphere by the solar wind."; answer[33, 1] = "Venus is closer to the Sun leading to higher temperatures."; answer[33, 2] = "Water evaporated, leading to higher temperatures and more evaporation."; answer[33, 3] = "High temperatures and the absence of water caused carbon dioxide to outgas " + Environment.NewLine +
                "from rocks and enter the atmosphere, leading to higher temperatures."; questiontype[33] = QuestionType.MultipleChoice;
            question[34] = "Where is most of the Earth's carbon dioxide?"; answer[34, 0] = "In rocks."; answer[34, 1] = "In the atmosphere."; answer[34, 2] = "In the oceans."; answer[34, 3] = "In the rainforests."; questiontype[34] = QuestionType.MultipleChoice;
            question[35] = "What happens to CO2 in the Earth's atmosphere during Snowball Earth periods?"; answer[35, 0] = "The amount of CO2 increases because outgassed CO2 " + Environment.NewLine +
                "cannot be dissolved in the frozen oceans."; answer[35, 1] = "The amount of CO2 increases because of the large amount " + Environment.NewLine +
                "of CO2 present in the global ice sheets."; answer[35, 2] = "The amount of CO2 decreases because the cold temperatures " + Environment.NewLine +
                "cause CO2 to condense out into the ice."; answer[35, 3] = "The amount of CO2 decreases because there is less volcanic " + Environment.NewLine +
                "activity during the cold Snowball Earth periods."; questiontype[35] = QuestionType.MultipleChoice;
            question[36] = "Which two bodies show evidence of heavy cratering?"; answer[36, 0] = "Mercury and Earth's Moon."; answer[36, 1] = "Mercury and Venus."; answer[36, 2] = "Mercury and Earth."; answer[36, 3] = "Earth and Mars."; questiontype[36] = QuestionType.MultipleChoice;
            question[37] = "Which two bodies show evidence of liquid water?"; answer[37, 0] = "Earth and Mars."; answer[37, 1] = "Mercury and Earth's Moon."; answer[37, 2] = "Mercury and Venus."; answer[37, 3] = "Mercury and Earth."; questiontype[37] = QuestionType.MultipleChoice;
            question[38] = "Which two bodies show evidence of a substantial atmosphere?"; answer[38, 0] = "Earth and Venus."; answer[38, 1] = "Mercury and Earth."; answer[38, 2] = "Earth and Mars."; answer[38, 3] = "Mercury and Earth's Moon."; questiontype[38] = QuestionType.MultipleChoice;
            question[39] = "How do we learn about Earth's core, mantle, and crust?"; answer[39, 0] = "Deep drilling and seismic waves."; answer[39, 1] = "Deep drilling."; answer[39, 2] = "Seismic waves."; answer[39, 3] = "X-ray imaging."; questiontype[39] = QuestionType.MultipleChoice;
            question[40] = "The inside of Earth is filled with molten lava"; answer[40, 0] = "False"; answer[40, 1] = "True"; answer[40, 2] = ""; answer[40, 3] = ""; questiontype[40] = QuestionType.TrueOrFalse;
            question[41] = "How do we know that Earth is geologically active?"; answer[41, 0] = "Volcanoes and seismology."; answer[41, 1] = "Volcanoes."; answer[41, 2] = "Seismology."; answer[41, 3] = "Measurements of internal temperature."; questiontype[41] = QuestionType.MultipleChoice;
            question[42] = "What is the lithosphere?"; answer[42, 0] = "A relatively rigid outer layer of rock that floats on molten rock below."; answer[42, 1] = "The boundary between the core and mantle."; answer[42, 2] = "The crust plus the mantle."; answer[42, 3] = "Another name for a planet's crust."; questiontype[42] = QuestionType.MultipleChoice;
            question[43] = "Where did Earth's (interior) heat come from?"; answer[43, 0] = "Impacts as Earth was accreting and radioactivity."; answer[43, 1] = "Impacts as Earth was accreting."; answer[43, 2] = "Volcanoes."; answer[43, 3] = "Radioactivity."; questiontype[43] = QuestionType.MultipleChoice;
            question[44] = "How does an object's rate of cooling vary with size?"; answer[44, 0] = "A larger object cools more slowly than a smaller object."; answer[44, 1] = "A larger object cools more rapidly than a smaller object."; answer[44, 2] = "A smaller object cools more slowly than a larger object."; answer[44, 3] = "Size has no effect on an object's rate of cooling."; questiontype[44] = QuestionType.MultipleChoice;
            question[45] = "What is the source of Earth's magnetic field?"; answer[45, 0] = "Molten metal circulating inside Earth."; answer[45, 1] = "Magnetic rocks."; answer[45, 2] = "Magnetized iron in Earth's crust."; answer[45, 3] = "Magnetized iron in Earth's core."; questiontype[45] = QuestionType.MultipleChoice;
            question[46] = "Why are smaller terrestrial bodies such as Mercury or the Moon geologically dead?"; answer[46, 0] = "They cooled off faster than Earth did."; answer[46, 1] = "They don't have volcanoes."; answer[46, 2] = "They don't have erosion."; answer[46, 3] = "They were hit by fewer meteorites than Earth."; questiontype[46] = QuestionType.MultipleChoice;
            question[47] = "Do you think seismology would work on the Moon?"; answer[47, 0] = "Yes."; answer[47, 1] = "No, because the Moon is geologically dead."; answer[47, 2] = "No, because there is no water or air."; answer[47, 3] = "No, because gravity is weaker on the moon."; questiontype[47] = QuestionType.MultipleChoice;
            question[48] = "Which of the following is an example of convection?"; answer[48, 0] = "Hot material inside a planet rises, and cool " + Environment.NewLine +
                "material sinks towards the center."; answer[48, 1] = "Heat radiates from a planet into space."; answer[48, 2] = "Heat travels from atom to atom from inside a planet to the outside."; answer[48, 3] = "Metal conducts energy throughout Earth's core."; questiontype[48] = QuestionType.MultipleChoice;
            question[49] = "What is true of convection that stresses a planet's crust?"; answer[49, 0] = "Mountains may form where the crust is pushed together and Cracks and valleys may form where the crust is pulled apart."; answer[49, 1] = "Mountains may form where the crust is pushed together."; answer[49, 2] = "Cracks and valleys may form where the crust is pulled apart."; answer[49, 3] = "Convection has no effect on a planet's crust."; questiontype[49] = QuestionType.MultipleChoice;
            question[50] = "What are the 4 basic processes that shape planetary surfaces?"; answer[50, 0] = "Tectonics, impacts, volcanoes, erosion."; answer[50, 1] = "Magnetic fields, impacts, volcanoes, erosion."; answer[50, 2] = "Magnetic fields, earthquakes, volcanoes, erosion."; answer[50, 3] = "Tectonics, impacts, erosion, magnetic fields."; questiontype[50] = QuestionType.MultipleChoice;
            question[51] = "The lunar crater Tycho is about 80 km (50 miles) across. It was probably made by "; answer[51, 0] = "an impactor about 8 km across."; answer[51, 1] = "the eruption of the large volcano in its center."; answer[51, 2] = "an impactor about 80 km across."; answer[51, 3] = "plate tectonics."; questiontype[51] = QuestionType.MultipleChoice;
            question[52] = "Why do the lunar highlands have many more craters than the lunar maria?"; answer[52, 0] = "Lava flooded the maria, hiding many craters and " + Environment.NewLine +
                "the less cratered surfaces are younger than those with more craters."; answer[52, 1] = "Lava flooded the maria, hiding many craters."; answer[52, 2] = "The less cratered surfaces are younger than those with more craters."; answer[52, 3] = "They are on the side of the Moon away from Earth, which was hit by more impacts."; questiontype[52] = QuestionType.MultipleChoice;
            question[53] = "What seems to have made the very long cliffs on Mercury?"; answer[53, 0] = "Cooling and shrinking when the planet became geologically dead."; answer[53, 1] = "Volcanoes."; answer[53, 2] = "Earthquakes."; answer[53, 3] = "Meteorite impacts."; questiontype[53] = QuestionType.MultipleChoice;
            question[54] = "Why do we think Mars had more volcanic activity in the past than it does today?"; answer[54, 0] = "Mars would have been warmer in the past and some meteorites from Mars come from relatively young lava."; answer[54, 1] = "Mars would have been warmer in the past."; answer[54, 2] = "Some meteorites from Mars come from relatively young lava."; answer[54, 3] = "Mars was bombarded with more impacts in the past, which fueled more volcanic activity."; questiontype[54] = QuestionType.MultipleChoice;
            question[55] = "What evidence is there for past liquid water is on Mars?"; answer[55, 0] = "All of the above."; answer[55, 1] = "Ice in Mars' polar caps."; answer[55, 2] = "Spirit and Opportunity rovers have found mineral evidence of water."; answer[55, 3] = "Channels that look like dry riverbeds."; questiontype[55] = QuestionType.MultipleChoice;
            question[56] = "Since Venus is covered with thick clouds, "; answer[56, 0] = "we observe it with radar and we observe it with landers."; answer[56, 1] = "we observe it with radar."; answer[56, 2] = "we observe it with landers."; answer[56, 3] = "we presume it has active volcanoes."; questiontype[56] = QuestionType.MultipleChoice;
            question[57] = "The interior of Earth consists of "; answer[57, 0] = "a metallic core and solid rock outer shell."; answer[57, 1] = "a rocky core and metallic outer shell."; answer[57, 2] = "a metallic core and liquid rock outer shell."; answer[57, 3] = "a liquid rocky inner core and solid rock outer shell."; questiontype[57] = QuestionType.MultipleChoice;
            question[58] = "Suppose Venus rotated as fast as Earth. How would this change its relative " + Environment.NewLine +
                "levels of volcanism, tectonics, and erosion?"; answer[58, 0] = "Levels of volcanism and tectonics would stay the same, but " + Environment.NewLine +
                "erosion levels would be higher."; answer[58, 1] = "All three would be lower."; answer[58, 2] = "All three would be higher."; answer[58, 3] = "All would remain the same – they are independent of rotation."; questiontype[58] = QuestionType.MultipleChoice;
            question[59] = "What are the main constituents of Earth's atmosphere?"; answer[59, 0] = "Nitrogen and oxygen."; answer[59, 1] = "Hydrogen and helium."; answer[59, 2] = "Oxygen and carbon dioxide."; answer[59, 3] = "Water vapor and oxygen."; questiontype[59] = QuestionType.MultipleChoice;
            question[60] = "Why is atmospheric pressure less on top of a mountain than at sea level?"; answer[60, 0] = "The pressure at every height in the atmosphere equals " + Environment.NewLine +
                "the weight of the air above it."; answer[60, 1] = "It is cooler in the mountains."; answer[60, 2] = "Denser air sinks to sea level; the air on mountains is lighter."; answer[60, 3] = "None of the above."; questiontype[60] = QuestionType.MultipleChoice;
            question[61] = "If there was no greenhouse effect, Earth "; answer[61, 0] = "would be colder than freezing."; answer[61, 1] = "would have a thicker atmosphere."; answer[61, 2] = "would be warmer than it is today."; answer[61, 3] = "would have no protection from ultraviolet radiation."; questiontype[61] = QuestionType.MultipleChoice;
            question[62] = "If Earth was more reflective (had a higher albedo), what would happen to its temperature?"; answer[62, 0] = "It would go down."; answer[62, 1] = "It would go up."; answer[62, 2] = "It wouldn't change."; answer[62, 3] = "It would vary."; questiontype[62] = QuestionType.MultipleChoice;
            question[63] = "If Earth didn't have an atmosphere, what would happen to its temperature?"; answer[63, 0] = "It would go down a lot."; answer[63, 1] = "It would go down a little."; answer[63, 2] = "It would go up a lot."; answer[63, 3] = "It would go up a little."; questiontype[63] = QuestionType.MultipleChoice;
            question[64] = "Which of the following correctly states the  layers of Earth's atmosphere from " + Environment.NewLine +
                "closest to the surface to closest to space?"; answer[64, 0] = "Troposphere, stratosphere, thermosphere, exosphere."; answer[64, 1] = "Troposphere, stratosphere, exosphere, thermosphere."; answer[64, 2] = "Stratosphere, exosphere, thermosphere, troposphere."; answer[64, 3] = "Thermosphere, troposphere, stratosphere, exosphere."; questiontype[64] = QuestionType.MultipleChoice;
            question[65] = "Infrared radiation emitted by Earth's surface "; answer[65, 0] = "All of the above."; answer[65, 1] = "heats the troposphere from below."; answer[65, 2] = "causes convection."; answer[65, 3] = "causes weather (storms)."; questiontype[65] = QuestionType.MultipleChoice;
            question[66] = "The stratosphere is heated by"; answer[66, 0] = "ultraviolet light from the Sun."; answer[66, 1] = "warm air rising from the troposphere."; answer[66, 2] = "convection."; answer[66, 3] = "X-rays."; questiontype[66] = QuestionType.MultipleChoice;
            question[67] = "The sky is blue because "; answer[67, 0] = "the blue light in sunlight scatters more than the red light."; answer[67, 1] = "of the reflection of the oceans."; answer[67, 2] = "blue is the color of oxygen gas."; answer[67, 3] = "blue is the color of nitrogen gas."; questiontype[67] = QuestionType.MultipleChoice;
            question[68] = "What protects Earth from the high energy particles shot from the Sun (the solar wind)?"; answer[68, 0] = "The magnetosphere."; answer[68, 1] = "The troposphere."; answer[68, 2] = "The stratosphere"; answer[68, 3] = "The exosphere"; questiontype[68] = QuestionType.MultipleChoice;
            question[69] = "What affects the global circulation pattern of Earth's atmosphere?"; answer[69, 0] = "All of the above."; answer[69, 1] = "Hot air from the equator rising, cool air at the poles falling."; answer[69, 2] = "Earth's rotation."; answer[69, 3] = "Convection."; questiontype[69] = QuestionType.MultipleChoice;
            question[70] = "What is the main source of the original atmospheres of the terrestrial planets?"; answer[70, 0] = "Gas released from interior rocks (outgassing)."; answer[70, 1] = "Gas accreted from the solar nebula."; answer[70, 2] = "Comets."; answer[70, 3] = "Evaporation from ice."; questiontype[70] = QuestionType.MultipleChoice;
            question[71] = "Where did the hydrogen in Earth's atmosphere go?"; answer[71, 0] = "It escaped into space."; answer[71, 1] = "We never had any."; answer[71, 2] = "It dissolved in the oceans and was incorporated into rocks."; answer[71, 3] = "None of the above."; questiontype[71] = QuestionType.MultipleChoice;
            question[72] = "Where did the carbon dioxide in Earth's atmosphere go?"; answer[72, 0] = "It dissolved in the oceans and was incorporated into rocks."; answer[72, 1] = "We never had any."; answer[72, 2] = "It escaped into space."; answer[72, 3] = "None of the above."; questiontype[72] = QuestionType.MultipleChoice;
            question[73] = "Why do we think Mars was once warmer and wetter?"; answer[73, 0] = "All of the above."; answer[73, 1] = "It has plenty of volcanoes to outgas an atmosphere."; answer[73, 2] = "It doesn't have strong magnetic field to protect from solar wind stripping."; answer[73, 3] = "There is evidence it once had liquid water. It is too cold for that now."; questiontype[73] = QuestionType.MultipleChoice;
            question[74] = "What is the main reason that Venus is warmer than Earth?"; answer[74, 0] = "The greenhouse effect is much higher on Venus than on Earth."; answer[74, 1] = "Venus is closer to the Sun than Earth."; answer[74, 2] = "Venus has a higher reflectivity than Earth."; answer[74, 3] = "Venus has a lower reflectivity than Earth."; questiontype[74] = QuestionType.MultipleChoice;
            question[75] = "Suppose we could magically replace Venus' actual atmosphere with an atmosphere " + Environment.NewLine +
                "identical to Earth's. Could liquid water exist on its surface?"; answer[75, 0] = "Yes, the surface temperature would be well below " + Environment.NewLine +
                "the boiling point of water."; answer[75, 1] = "Yes, the conditions would be exactly as on Earth."; answer[75, 2] = "No, the low pressure would ensure that liquid water " + Environment.NewLine +
                "would immediately evaporate."; answer[75, 3] = "No, the runaway greenhouse effect would ensure that " + Environment.NewLine +
                "liquid water would immediately evaporate."; questiontype[75] = QuestionType.MultipleChoice;
            question[76] = "Suppose that, somehow, all plants died out. What would happen to the oxygen " + Environment.NewLine +
                "in our atmosphere?"; answer[76, 0] = "The oxygen would eventually be used up in oxidation reactions with the surface."; answer[76, 1] = "The oxygen would initially decrease, but as greenhouse gases and " + Environment.NewLine +
                "temperature increased, it would recover to its normal value."; answer[76, 2] = "The oxygen would increase as plants would not exist to " + Environment.NewLine +
                "remove it from the atmosphere."; answer[76, 3] = "Plants grow by intaking carbon and therefore the oxygen " + Environment.NewLine +
                "content would be unaffected."; questiontype[76] = QuestionType.MultipleChoice;
            question[77] = "Surprising discovery? - A planet in another solar system that has an " + Environment.NewLine +
                "Earth-like atmosphere with plentiful oxygen, but no life of any kind."; answer[77, 0] = "Implausible. Oxygen is highly reactive and its presence in " + Environment.NewLine +
                "an atmosphere suggests replenishment by a living organism of some sort."; answer[77, 1] = "Implausible. Oxygen is essential to life."; answer[77, 2] = "Plausible. The oxygen may have been transported there by cometary impacts."; answer[77, 3] = "Plausible. Life requires far more than oxygen to exist."; questiontype[77] = QuestionType.MultipleChoice;
            question[78] = "What is differentiation in planetary geology?"; answer[78, 0] = "The process by which gravity separates materials according to density."; answer[78, 1] = "Any process by which one part of a planet's surface evolves " + Environment.NewLine +
                "differently from another part of the same planet's surface"; answer[78, 2] = "Any process by which a planet's surface evolves differently from " + Environment.NewLine +
                "another planet's surface."; answer[78, 3] = "The process by which different types of minerals form a conglomerate rock."; questiontype[78] = QuestionType.MultipleChoice;
            question[79] = "What are the circumstances under which convection can occur in a substance?"; answer[79, 0] = "When the substance is strongly heated from underneath."; answer[79, 1] = "When the substance is strongly cooled from underneath."; answer[79, 2] = "When the substance is subjected to a strong magnetic field."; answer[79, 3] = "When dense material is being added to the substance."; questiontype[79] = QuestionType.MultipleChoice;
            question[80] = "Which of the following best describes why the smaller terrestrial worlds " + Environment.NewLine +
                "have cooler interiors than the larger ones?"; answer[80, 0] = "They have relatively more surface area compared to their volumes."; answer[80, 1] = "The smaller ones are farther from the Sun."; answer[80, 2] = "They have relatively fewer radioactive elements."; answer[80, 3] = "They were cooler when they formed."; questiontype[80] = QuestionType.MultipleChoice;
            question[81] = "Which two properties are most important in determining the surface temperature of a planet?"; answer[81, 0] = "Distance from the Sun and atmosphere."; answer[81, 1] = "Size and atmosphere."; answer[81, 2] = "Internal temperature and atmosphere."; answer[81, 3] = "Composition and distance from the Sun."; questiontype[81] = QuestionType.MultipleChoice;
            question[82] = "Which of the following planets has the least substantial atmosphere?"; answer[82, 0] = "Mercury"; answer[82, 1] = "Venus"; answer[82, 2] = "Mars"; answer[82, 3] = "Neptune"; questiontype[82] = QuestionType.MultipleChoice;

            order = new int[numberOfQuestions];
            randomOrder = new int[numberOfQuestions];

            for (int i = 0; i < numberOfQuestions; i++)
            {
                order[i] = i;
                randomOrder[i] = i;
            }
        }

        public Chapter7()
        {
            Setup_Questions();
        }

        public void Randomize_Questions()
        {
            Random rnd = new Random();
            randomOrder = order.OrderBy(x => rnd.Next()).ToArray();
        }

        public string Get_Question(int index)
        {
            if (index >= 0 && index < numberOfQuestions)
            {
                return question[index];
            }

            return string.Empty;
        }

        public string Get_Answer(int index)
        {
            if (index >= 0 && index < numberOfQuestions)
            {
                return answer[index, 0];
            }

            return string.Empty;
        }

        public int Get_Number_Of_Questions()
        {
            return numberOfQuestions;
        }

        public int Get_Minutes()
        {
            return minutes;
        }

        public int Get_Seconds()
        {
            return seconds;
        }
    }
}
