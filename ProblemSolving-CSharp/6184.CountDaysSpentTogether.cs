using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _6184
    {
        public int CountDaysTogether(string arriveAlice, string leaveAlice, string arriveBob, string leaveBob)
        {

            //Converting string to DateTime
            string arriveAliceMonth = arriveAlice.Substring(0, 2);
            string arriveAliceDate = arriveAlice.Substring(3, 2); 
            string arriveAliceF = arriveAliceDate + "/" + arriveAliceMonth + "/2022"; 
            DateTime aliceArr = DateTime.ParseExact(arriveAliceF, "dd/MM/yyyy", null);


            string leaveAliceMonth = leaveAlice.Substring(0, 2);
            string leaveAliceDate = leaveAlice.Substring(3, 2); 
            string leaveAliceF = leaveAliceDate + "/" + leaveAliceMonth + "/2022"; 
            DateTime aliceLea = DateTime.ParseExact(leaveAliceF, "dd/MM/yyyy", null); 


            string arriveBobMonth = arriveBob.Substring(0, 2);
            string arriveBobDate = arriveBob.Substring(3, 2); 
            string arriveBobF = arriveBobDate + "/" + arriveBobMonth + "/2022"; 
            DateTime bobArr = DateTime.ParseExact(arriveBobF, "dd/MM/yyyy", null);


            string leaveBobMonth = leaveBob.Substring(0, 2);
            string leaveBobDate = leaveBob.Substring(3, 2); 
            string leaveBobF = leaveBobDate + "/" + leaveBobMonth + "/2022"; 
            DateTime bobLea = DateTime.ParseExact(leaveBobF, "dd/MM/yyyy", null);


            // If they don't intersect return 0.
            if (!(aliceArr <= bobLea && aliceLea >= bobArr))
            {
                return 0;
            }

            // Take the highest start date and the lowest end date.
            DateTime start = aliceArr > bobArr ? aliceArr : bobArr;
            DateTime end = aliceLea > bobLea ? bobLea : aliceLea;

            // Add one to the time range since its inclusive.
            return (int)(end - start).TotalDays + 1;

        }
    }
}
