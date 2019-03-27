class queenB
    {
        //  The queen has a number 
        public int id_number;

       

        // The Queen knows the shifts left of each worker bee
        private int shifts_left;

        // The queen has a collection of MGMT bees
        private mgmtB[] mgmt;

        
        public queenB (workerB[] workers)
        {
            Workers = workers;
        }
        private int shiftNumber = 0;

        
        private workerB[] Workers;

        //  The Queen is responsible of assigning work

        public bool AssignWork(string job_description, int number_of_shifts)
        {
            for (int i = 0; i < Workers.Length; i++)
            {
                if (Workers[i].DoThisJob(job_description, number_of_shifts))
                {
                    return true;
                }
            }


            return false ;
        }

        //  The Queen checks to see if the shift has been completed.
        public string WorkTheNextshif()
        {
            shiftNumber++;
            string report = "Report for shift #" + shiftNumber + "\r\n";

            for (int i = 0; i < Workers.Length; i++)
            {
                if (Workers[i].WorkOneShift())
                {
                    report += "Worker #"+(i + 1) + " finished the job \r\n";
                }
                if (String.IsNullOrEmpty(Workers[1].CurrentJob))
                {
                    report += "Worker #" + (i + 1) + " is not working \r\n";

                
                }
                else
                {
                    if (Workers[i].ShiftsLeft > 0)
                    {
                        report += "Worker #" + (i + 1) + "is doing '" + Workers[i].CurrentJob + " ' for " +
                            Workers[i].ShiftsLeft + " more shifts \r\n";

                    }
                    else
                    {
                        report += "Worker #" + (i + 1) + " will be done with '" + Workers[i].CurrentJob + "' after this shift\r\n";
                    }
                }
            }

            return report;

        }
    }
