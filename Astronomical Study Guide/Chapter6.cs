using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astronomical_Study_Guide
{
    class Chapter6
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
            numberOfQuestions = 52;
            numberOfAnswers = 4;
            question = new string[numberOfQuestions];
            answer = new string[numberOfQuestions, numberOfAnswers];
            questiontype = new QuestionType[numberOfQuestions];
            mastered = new bool[numberOfQuestions];

            question[0] = "In order to be successful, a theory of the formation of the solar system must " + Environment.NewLine +
                "explain"; answer[0, 0] = "All of the above."; answer[0, 1] = "The exceptions to the general rules."; answer[0, 2] = "Why comets reside in the Kuiper belt and Oort cloud."; answer[0, 3] = "The orderly patterns of motion of objects."; questiontype[0] = QuestionType.MultipleChoice;
            question[1] = "Which of the following is not a problem for the close encounter hypothesis for " + Environment.NewLine +
                "the origin of the planets?"; answer[1, 0] = "none of the above (all are problems with the close encounter hypothesis)"; answer[1, 1] = "It relies on an improbable event (a very close encounter " + Environment.NewLine +
                "between the Sun and another star)."; answer[1, 2] = "It predicts that planetary systems are rare."; answer[1, 3] = "It fails to explain the orbits of the planets."; questiontype[1] = QuestionType.MultipleChoice;
            question[2] = "What is the origin of the elements that made up the protoplanetary nebula?"; answer[2, 0] = "They were formed inside stars or supernovae that " + Environment.NewLine +
                "exploded before the solar system formed."; answer[2, 1] = "They were produced in the big bang."; answer[2, 2] = "They were produced in the Sun's early strong solar wind."; answer[2, 3] = "They were formed by fusion at the time of the formation of " + Environment.NewLine +
                "the Milky Way galaxy."; questiontype[2] = QuestionType.MultipleChoice;
            question[3] = "Why was the protoplanetary nebula flat?"; answer[3, 0] = "It flattened as a result of collisions between " + Environment.NewLine +
                "particles in the nebula."; answer[3, 1] = "Nebulae form in a variety of shapes, and ours " + Environment.NewLine +
                "happened to be disk-shaped."; answer[3, 2] = "The nebula became flat due to gravitational " + Environment.NewLine +
                "contraction along its axis."; answer[3, 3] = "The force of a nearby supernova flattened the nebula."; questiontype[3] = QuestionType.MultipleChoice;
            question[4] = "Which of the following processes did not contribute to orderly motions in the " + Environment.NewLine +
                "solar system?"; answer[4, 0] = "Hotter temperatures closer to the Sun and cooler temperatures farther from the Sun " + Environment.NewLine +
                "caused different materials to condense at different distances from the Sun."; answer[4, 1] = "As the nebula shrank, conservation of angular momentum." + Environment.NewLine +
                "resulted in an increased spin rate."; answer[4, 2] = "Collisions between particles canceled out random motions."; answer[4, 3] = "None of the above (all contributed to orderly motions)."; questiontype[4] = QuestionType.MultipleChoice;
            question[5] = "Which lists the ingredients of the solar nebula in order of increasing " + Environment.NewLine +
                "abundance?"; answer[5, 0] = "Metals, rocks, hydrogen compounds."; answer[5, 1] = "Rocks, metals, hydrogen compounds."; answer[5, 2] = "Hydrogen compounds, metals, rocks."; answer[5, 3] = "Hydrogen compounds, rocks, metals."; questiontype[5] = QuestionType.MultipleChoice;
            question[6] = "Why are the planets closest to the Sun more dense than those farther from " + Environment.NewLine +
                "the Sun?"; answer[6, 0] = "Only dense materials could condense close to the " + Environment.NewLine +
                "Sun."; answer[6, 1] = "Dense objects sink toward the Sun while less dense " + Environment.NewLine +
                "objects are less strongly bound by the Sun's gravity."; answer[6, 2] = "Jupiter scattered denser planets inward and less dense " + Environment.NewLine +
                "objects outward."; answer[6, 3] = "The heat at that proximity to the Sun makes it difficult " + Environment.NewLine +
                "for them to think."; questiontype[6] = QuestionType.MultipleChoice;
            question[7] = "Where did hydrogen and helium gas condense in the protoplanetary nebula?"; answer[7, 0] = "Nowhere."; answer[7, 1] = "Throughout the solar system."; answer[7, 2] = "Only inside the frost line."; answer[7, 3] = "Only outside the frost line."; questiontype[7] = QuestionType.MultipleChoice;
            question[8] = "How did the small particles that condensed in the solar nebula " + Environment.NewLine +
                "accrete to grow into planetesimals?"; answer[8, 0] = "They collided gently and stuck together through " + Environment.NewLine +
                "electrostatic forces."; answer[8, 1] = "They collided gently and stuck together through " + Environment.NewLine +
                "magnetic forces."; answer[8, 2] = "They collided gently and stuck together through the " + Environment.NewLine +
                "gravitational force."; answer[8, 3] = "They collided forcefully so that they stuck together " + Environment.NewLine +
                "through mechanical forces."; questiontype[8] = QuestionType.MultipleChoice;
            question[9] = "How did the formation of jovian planets differ from the formation of terrestrial planets?"; answer[9, 0] = "The jovian planetesimals became large enough to " + Environment.NewLine +
                "gravitationally capture hydrogen and helium from the " + Environment.NewLine +
                "nebula."; answer[9, 1] = "The jovian planetesimals were larger than those that made " + Environment.NewLine +
                "terrestrial planets."; answer[9, 2] = "The jovian planetesimals formed by direct collapse of the " + Environment.NewLine +
                "gas in the solar nebula rather than accretion of planetesimals."; answer[9, 3] = "The jovian planetesimals were icier than those that made " + Environment.NewLine +
                "terrestrial planets."; questiontype[9] = QuestionType.MultipleChoice;
            question[10] = "What condensed beyond the frost line?"; answer[10, 0] = "All of the above."; answer[10, 1] = "Hydrogen compounds."; answer[10, 2] = "Rocks."; answer[10, 3] = "Metals."; questiontype[10] = QuestionType.MultipleChoice;
            question[11] = "Why does the Sun rotate slowly today?"; answer[11, 0] = "The Sun transferred angular momentum to charged " + Environment.NewLine +
                "particles in the solar wind."; answer[11, 1] = "The rate of the Sun's rotation is a consequence of the solar " + Environment.NewLine +
                "nebula's initial angular momentum."; answer[11, 2] = "The Sun transferred angular momentum to the planets " + Environment.NewLine +
                "through torques when the planets formed."; answer[11, 3] = "The Sun gradually slowed down as material flowed into it " + Environment.NewLine +
                "through the solar nebula."; questiontype[11] = QuestionType.MultipleChoice;
            question[12] = "Why did planet formation eventually end?"; answer[12, 0] = "The solar wind removed the remaining nebular gas."; answer[12, 1] = "There were no more planetesimals left."; answer[12, 2] = "All gas was captured by the jovian planets."; answer[12, 3] = "The planets migrated to orbits farther from the Sun " + Environment.NewLine +
                "where there was not any gas or planetesimals."; questiontype[12] = QuestionType.MultipleChoice;
            question[13] = "What happened to most of the mass originally in the asteroid belt?"; answer[13, 0] = "Some of it crashed into the inner planets while " + Environment.NewLine +
                "some was ejected from the solar system."; answer[13, 1] = "It became part of Mars."; answer[13, 2] = "It became part of Jupiter."; answer[13, 3] = "It is still in the asteroid belt."; questiontype[13] = QuestionType.MultipleChoice;
            question[14] = "Why do some of Jupiter's moons orbit in the opposite direction of Jupiter's rotation?"; answer[14, 0] = "They are captured planetesimals that encountered " + Environment.NewLine +
                "Jupiter in such a way that they ended up orbiting " + Environment.NewLine +
                "backward."; answer[14, 1] = "When moons form in a circumplanetary nebula they have " + Environment.NewLine +
                "roughly equal probability of orbiting forward and backward."; answer[14, 2] = "Jupiter's strong tidal force caused the orbits to evolve into " + Environment.NewLine +
                "backward orbits. "; answer[14, 3] = "Jupiter's rotation is backward due to a giant impact, so its " + Environment.NewLine +
                "forward-orbiting moons are orbiting in the opposite direction " + Environment.NewLine +
                "of Jupiter's spin."; questiontype[14] = QuestionType.MultipleChoice;
            question[15] = "Which of the following features of the solar system can be explained by " + Environment.NewLine +
                "giant impacts?"; answer[15, 0] = "The existence of Earth's large moon."; answer[15, 1] = "The existence of Mars's two small moons."; answer[15, 2] = "The backward orbit of Neptune's moon Triton."; answer[15, 3] = "The large number of objects in the asteroid belt."; questiontype[15] = QuestionType.MultipleChoice;
            question[16] = "Which of the following characteristics of the solar system would we not " + Environment.NewLine +
                "necessarily expect to find around other stars?"; answer[16, 0] = "A terrestrial planet with a large moon."; answer[16, 1] = "A distant disk of comets like the Kuiper belt."; answer[16, 2] = "Jovian planets."; answer[16, 3] = "An Oort cloud of comets."; questiontype[16] = QuestionType.MultipleChoice;
            question[17] = "Radiometric dating can be used to determine the amount of time since "; answer[17, 0] = "a rock most recently solidified."; answer[17, 1] = "a rock first solidified."; answer[17, 2] = "the elements in a rock were formed inside stars or a supernova."; answer[17, 3] = "the Big Bang."; questiontype[17] = QuestionType.MultipleChoice;
            question[18] = "How old are the oldest meteorites?"; answer[18, 0] = "4.55 billion years."; answer[18, 1] = "4.35 billion years."; answer[18, 2] = "5.45 billion years."; answer[18, 3] = "3.95 billion years."; questiontype[18] = QuestionType.MultipleChoice;
            question[19] = "How do we verify the validity of radiometric dating?"; answer[19, 0] = "Some archeological artifacts have dates on them and " + Environment.NewLine +
                "we use multiple radiometric techniques to see if " + Environment.NewLine +
                "the same ages are found."; answer[19, 1] = "Some archeological artifacts have dates on them."; answer[19, 2] = "We use multiple radiometric techniques to see if " + Environment.NewLine +
                "the same ages are found."; answer[19, 3] = "None of the above."; questiontype[19] = QuestionType.MultipleChoice;
            question[20] = "Why do we think that the solar system formed from a rotating, collapsing " + Environment.NewLine +
                "gas cloud that ended up as a disk orbiting the Sun?"; answer[20, 0] = "All of the above."; answer[20, 1] = "We see disks around young stars."; answer[20, 2] = "We see clouds of gas and dust in space."; answer[20, 3] = "Most of the planets revolve and rotate in the same " + Environment.NewLine +
                "direction and in the same plane."; questiontype[20] = QuestionType.MultipleChoice;
            question[21] = "What is the primary physical law responsible for the heating of the solar " + Environment.NewLine +
                "nebula as it collapsed?"; answer[21, 0] = "Conservation of energy."; answer[21, 1] = "Conservation of momentum."; answer[21, 2] = "Conservation of angular momentum."; answer[21, 3] = "Kepler's third law."; questiontype[21] = QuestionType.MultipleChoice;
            question[22] = "What is the primary physical law responsible for the increased rotation " + Environment.NewLine +
                "rate of the solar nebula as it collapsed?"; answer[22, 0] = "Conservation of momentum."; answer[22, 1] = "Conservation of energy."; answer[22, 2] = "Conservation of angular momentum."; answer[22, 3] = "Kepler's third law."; questiontype[22] = QuestionType.MultipleChoice;
            question[23] = "Why do we think the inner (terrestrial) planets became more dense than the " + Environment.NewLine +
                "outer planets?"; answer[23, 0] = "The inner part of the solar nebula was so hot that only " + Environment.NewLine +
                "dense metals and rocks were able to accrete there."; answer[23, 1] = "As the solar nebula collapsed, denser materials sank " + Environment.NewLine +
                "toward the center."; answer[23, 2] = "The Sun's gravity pulled denser materials toward the " + Environment.NewLine +
                "center."; answer[23, 3] = "The rotating disk in which the planets formed flung lighter " + Environment.NewLine +
                "elements outward by centrifugal force."; questiontype[23] = QuestionType.MultipleChoice;
            question[24] = "What do we think the composition of the solar nebula was?"; answer[24, 0] = "About 98% hydrogen and helium, and 2% " + Environment.NewLine +
                "heavier elements."; answer[24, 1] = "About 2% hydrogen and helium, and 98% heavier " + Environment.NewLine +
                "elements."; answer[24, 2] = "About half hydrogen and helium, half heavier " + Environment.NewLine +
                "elements (iron, carbon, silicon, etc.)."; answer[24, 3] = "An unknown amount of rocks, metals, hydrogen compounds, " + Environment.NewLine +
                "and ice."; questiontype[24] = QuestionType.MultipleChoice;
            question[25] = "What is the composition of the gas clouds (nebulae) we see in space?"; answer[25, 0] = "About 98% hydrogen and helium, and 2% " + Environment.NewLine +
                "heavier elements."; answer[25, 1] = "About 2% hydrogen and helium, and 98% heavier " + Environment.NewLine +
                "elements."; answer[25, 2] = "About half hydrogen and helium, half heavier " + Environment.NewLine +
                "elements (iron, carbon, silicon, etc.)."; answer[25, 3] = "An unknown amount of rocks, metals, hydrogen compounds, " + Environment.NewLine +
                "and ice."; questiontype[25] = QuestionType.MultipleChoice;
            question[26] = "What do we think condensed out of the solar nebula?"; answer[26, 0] = "All except Hydrogen and Helium."; answer[26, 1] = "Hydrogen compounds."; answer[26, 2] = "Rocky material."; answer[26, 3] = "Metals."; questiontype[26] = QuestionType.MultipleChoice;
            question[27] = "How much of the solar nebula condensed in the inner regions (where the temperature " + Environment.NewLine +
                "was greater than 1300 K) and in the outer regions (where the temperatures were less " + Environment.NewLine +
                "than 150 K) ?"; answer[27, 0] = "About 0.2% in the inner regions and 1.4% in the outer regions."; answer[27, 1] = "0% in the inner regions and about 2% in the outer regions."; answer[27, 2] = "0% in the inner regions and 100% in the outer regions."; answer[27, 3] = "About 2% in both inner and outer regions."; questiontype[27] = QuestionType.MultipleChoice;
            question[28] = "The dense, rocky, and metallic planets are found close to the Sun because "; answer[28, 0] = "rocks and metals condensed at the relatively high " + Environment.NewLine +
                "temperatures close to the Sun."; answer[28, 1] = "The Sun's gravity attracted the denser particles (rocks and " + Environment.NewLine +
                "metals) closer to it."; answer[28, 2] = "The Sun was unable to hold onto the lighter (gaseous) " + Environment.NewLine +
                "particles and they moved farther away where they formed the outer planets."; answer[28, 3] = "They were nudged inward by close encounters with Jupiter " + Environment.NewLine +
                "early in the solar system's history."; questiontype[28] = QuestionType.MultipleChoice;
            question[29] = "What do we think first caused tiny solid bits of material in the solar nebula " + Environment.NewLine +
                "to accrete?"; answer[29, 0] = "Electrical forces."; answer[29, 1] = "Gravity."; answer[29, 2] = "Friction."; answer[29, 3] = "Pressure."; questiontype[29] = QuestionType.MultipleChoice;
            question[30] = "When the first solid bits in the solar nebula became large enough to be " + Environment.NewLine +
                "called planetesimals, what caused them to grow larger more quickly?"; answer[30, 0] = "Gravity."; answer[30, 1] = "Friction."; answer[30, 2] = "Electrical Forces."; answer[30, 3] = "Pressure."; questiontype[30] = QuestionType.MultipleChoice;
            question[31] = "Why could the jovian planets grow to be much larger than the terrestrial planets?"; answer[31, 0] = "They formed beyond the frost line where ices " + Environment.NewLine +
                "could condense, so they included hydrogen " + Environment.NewLine +
                "compounds."; answer[31, 1] = "They were farther from the Sun, where gravity was weaker."; answer[31, 2] = "They were far enough from the Sun to escape the " + Environment.NewLine +
                "heavy bombardment that battered the early solar " + Environment.NewLine +
                "system."; answer[31, 3] = "Greenhouse gases in combination of electromagnetic forces " + Environment.NewLine +
                "were able to trap the Hydrogen and Helium much more easily."; questiontype[31] = QuestionType.MultipleChoice;
            question[32] = "What appears to have happened to increase the mass of jovian planets?"; answer[32, 0] = "Their gravity became strong enough to attract " + Environment.NewLine +
                "hydrogen and helium gas from the solar nebula."; answer[32, 1] = "They captured more gas from interstellar space."; answer[32, 2] = "They captured gas from the solar wind."; answer[32, 3] = "They captured more mass from heavy " + Environment.NewLine +
                "bombardment."; questiontype[32] = QuestionType.MultipleChoice;
            question[33] = "What is the solar wind?"; answer[33, 0] = "Atoms and particles ejected from the Sun" + Environment.NewLine +
                " at high speed."; answer[33, 1] = "Strong radiation that comes from the Sun."; answer[33, 2] = "Similar to winds on Earth, but faster and stronger."; answer[33, 3] = "Similar to winds on Earth, but less dense and weaker."; questiontype[33] = QuestionType.MultipleChoice;
            question[34] = "How do the stellar winds of young Sun-like stars compare to the solar wind we" + Environment.NewLine +
                " see from the Sun today?"; answer[34, 0] = "Young stars have much stronger winds."; answer[34, 1] = "Young stars don't have winds."; answer[34, 2] = "Young stars have weaker winds."; answer[34, 3] = "None of the above."; questiontype[34] = QuestionType.MultipleChoice;
            question[35] = "What do we think happened to the solar nebula after the planets formed?"; answer[35, 0] = "The solar wind helped blow the gas away."; answer[35, 1] = "The gas was all used up in planet formation."; answer[35, 2] = "The rest of the gas gradually drifted away."; answer[35, 3] = "The gas is still here–we just can't see it."; questiontype[35] = QuestionType.MultipleChoice;
            question[36] = "Where do asteroids come from?"; answer[36, 0] = "They are leftover planetesimals from the inner " + Environment.NewLine +
                "solar system."; answer[36, 1] = "They are the remains of a planet between Mars " + Environment.NewLine +
                "and Jupiter that broke up."; answer[36, 2] = "They are escaped small moons."; answer[36, 3] = "They are leftover planetesimals from the outer " + Environment.NewLine +
                "solar system."; questiontype[36] = QuestionType.MultipleChoice;
            question[37] = "Where do comets come from?"; answer[37, 0] = "They are leftover planetesimals from the outer " + Environment.NewLine +
                "solar system."; answer[37, 1] = "They are the remains of a planet between Mars " + Environment.NewLine +
                "and Jupiter that broke up."; answer[37, 2] = "They are escaped small moons."; answer[37, 3] = "They are leftover planetesimals from the inner " + Environment.NewLine +
                "solar system."; questiontype[37] = QuestionType.MultipleChoice;
            question[38] = "During the heavy bombardment early in the solar system's history, "; answer[38, 0] = "All of the above."; answer[38, 1] = "giant craters were made on the Moon."; answer[38, 2] = "giant craters were made on Mercury."; answer[38, 3] = "giant craters were made on Earth."; questiontype[38] = QuestionType.MultipleChoice;
            question[39] = "Could a solar system like ours have formed with the first generation of stars " + Environment.NewLine +
                "after the Big Bang?"; answer[39, 0] = "No, there would not have been enough metals " + Environment.NewLine +
                "and rock to form terrestrial planets."; answer[39, 1] = "No, the expansion of the universe would have torn " + Environment.NewLine +
                "the solar system apart."; answer[39, 2] = "No, there would not have been enough time to form " + Environment.NewLine +
                "planets."; answer[39, 3] = "Possibly – there is no physical reason why not."; questiontype[39] = QuestionType.MultipleChoice;
            question[40] = "What age would radiometric dating give for a chunk of recently solidified lava " + Environment.NewLine +
                "from Kilauea, an active volcano in Hawaii?"; answer[40, 0] = "Zero."; answer[40, 1] = "The half-life of potassium-40 (1.25 billion years)."; answer[40, 2] = "The half-life of Uranium-238 (4.5 billion years)."; answer[40, 3] = "The age of the volcano."; questiontype[40] = QuestionType.MultipleChoice;
            question[41] = "What age does radiometric dating give for Moon rocks and meteorites?"; answer[41, 0] = "About 4 billion years."; answer[41, 1] = "About 4 million years."; answer[41, 2] = "About 14 billion years."; answer[41, 3] = "Zero."; questiontype[41] = QuestionType.MultipleChoice;
            question[42] = "According to our theory of solar system formation, why do all the planets orbit " + Environment.NewLine +
                "the Sun in the same direction and in nearly the same plane?"; answer[42, 0] = "The laws of conservation of energy and conservation of angular momentum " + Environment.NewLine +
                "ensure that any rotating, collapsing cloud will end up as a spinning disk."; answer[42, 1] = "The Sun formed first, and as it grew in size it spread into a " + Environment.NewLine +
                "disk, rather like the way a ball of dough can be flattened into a pizza by spinning it."; answer[42, 2] = "Any planets that once orbited in the opposite direction or a " + Environment.NewLine +
                "different plane were ejected from the solar system."; answer[42, 3] = "Luck explains it, as we would expect that most other solar systems would " + Environment.NewLine +
                "not have all their planets orbiting in such a pattern."; questiontype[42] = QuestionType.MultipleChoice;
            question[43] = "What happened during the accretion phase of the early solar system?"; answer[43, 0] = "Particles grew by colliding and sticking together."; answer[43, 1] = "The solar nebula differentiated into metals inside of the frost line " + Environment.NewLine +
                "and ices beyond."; answer[43, 2] = "Large planetesimals captured atmospheres from the solar nebula."; answer[43, 3] = "Earth gained its oceans from icy planetesimal capture."; questiontype[43] = QuestionType.MultipleChoice;
            question[44] = "According to the nebular theory, what are asteroids and comets?"; answer[44, 0] = "They are leftover planetesimals that never accreted into planets."; answer[44, 1] = "They are the shattered remains of collisions between planets."; answer[44, 2] = "They are the shattered remains of collisions between moons."; answer[44, 3] = "They are chunks of rock or ice that condensed long after the " + Environment.NewLine +
                "planets and moons had formed."; questiontype[44] = QuestionType.MultipleChoice;
            question[45] = "1.	Why are the inner planets made of denser materials than the outer planets?"; answer[45, 0] = "In the inner part of the nebula only metals and rocks were able " + Environment.NewLine +
                "to condense because of the high temperatures, whereas hydrogen compounds, " + Environment.NewLine +
                "although more abundant, were only able to condense in the cooler outer regions."; answer[45, 1] = "When the solar nebula formed a disk, materials naturally segregated into bands, " + Environment.NewLine +
                "and in our particular solar system the denser materials settled nearer the Sun " + Environment.NewLine +
                "while lighter materials are found in the outer part."; answer[45, 2] = "In the beginning, when the protoplanetary disk was spinning faster, centrifugal " + Environment.NewLine +
                "forces flung the lighter materials toward the outer parts of the solar nebula."; answer[45, 3] = "Denser materials were heavier and sank to the center of the nebula."; questiontype[45] = QuestionType.MultipleChoice;
            question[46] = "According to our theory of solar system formation, why do we find some exceptions to the general rules and patterns of the planets?"; answer[46, 0] = "Most of the exceptions are the result of giant impacts."; answer[46, 1] = "The exceptions exist because, even though our theory is as correct as possible, " + Environment.NewLine +
                "nature never follows rules precisely."; answer[46, 2] = "The exceptions probably represent objects that were captured by our " + Environment.NewLine +
                "solar system from interstellar space."; answer[46, 3] = "The exceptions probably represent objects that formed recently, rather " + Environment.NewLine +
                "than early in the history of the solar system."; questiontype[46] = QuestionType.MultipleChoice;
            question[47] = "What do meteorites reveal about the solar system?"; answer[47, 0] = "They reveal that the age of the solar system is approximately 4.6 billion years."; answer[47, 1] = "They reveal that the early solar system consisted mostly of hydrogen and " + Environment.NewLine +
                "helium gas."; answer[47, 2] = "They reveal that the solar system once contained 10 planets."; answer[47, 3] = "They reveal that meteorites are much older than the comets and planets."; questiontype[47] = QuestionType.MultipleChoice;
            question[48] = "What percentage of the solar nebula's mass consisted of hydrogen and helium gases?"; answer[48, 0] = "98 percent"; answer[48, 1] = "100 percent"; answer[48, 2] = "0.5 percent"; answer[48, 3] = "50 percent"; questiontype[48] = QuestionType.MultipleChoice;
            question[49] = "The age of the solar system can be established by radioactive dating of "; answer[49, 0] = "the oldest meteorites."; answer[49, 1] = "the oldest rocks on the Moon."; answer[49, 2] = "the oldest Earth rocks."; answer[49, 3] = "the atmosphere of Mars."; questiontype[49] = QuestionType.MultipleChoice;
            question[50] = "Based on our current theory of Earth's formation, the water we drink comes from"; answer[50, 0] = "comets that impacted Earth."; answer[50, 1] = "chemical reactions that occurred in Earth's crust after Earth formed."; answer[50, 2] = "chemical reactions that occurred in Earth's core after Earth formed."; answer[50, 3] = "ice that condensed in the solar nebula in the region where Earth formed."; questiontype[50] = QuestionType.MultipleChoice;
            question[51] = "Why did the solar nebula flatten into a disk?"; answer[51, 0] = "It flattened as a natural consequence of collisions between particles " + Environment.NewLine +
                "in the spinning nebula, changing random motions into more orderly ones."; answer[51, 1] = "The force of gravity from the planets pulled the material downward into " + Environment.NewLine +
                "a flat disk."; answer[51, 2] = "The interstellar cloud from which the solar nebula formed was originally " + Environment.NewLine +
                "somewhat flat."; answer[51, 3] = "The force of gravity from the Sun pulled the material downward into " + Environment.NewLine +
                "a flat disk."; questiontype[51] = QuestionType.MultipleChoice;

            order = new int[numberOfQuestions];
            randomOrder = new int[numberOfQuestions];

            for (int i = 0; i < numberOfQuestions; i++)
            {
                order[i] = i;
                randomOrder[i] = i;
            }
        }

        public Chapter6()
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
