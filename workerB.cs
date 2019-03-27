class workerB
    {
        private string[] JobsICanDo;

        public workerB (string[] jobsIcanDo)
        {
            JobsICanDo = jobsIcanDo;
        }

        private string currentJob = "";
        public string CurrentJob
        {
            get { return currentJob; }
        }
        private int shiftsToWork;
        private int shiftsWorked;

        public int ShiftsLeft
        {
            get { return shiftsToWork - shiftsWorked; }
        }

        public bool DoThisJob(string job, int numberOfShifts)
        {
            if (!String.IsNullOrEmpty(currentJob))
            { return false; }

            for (int i =0; i < JobsICanDo.Length; i++)
            {
                if (JobsICanDo[i] == job)
                {
                    currentJob = job;
                    shiftsToWork = numberOfShifts;
                    shiftsWorked = 0;
                    return true;
                }
                
            }
            return false;
        }


        public bool WorkOneShift()
        {
            if (!String.IsNullOrEmpty(currentJob))
            { return false; }

            shiftsWorked++;

            if (shiftsWorked > shiftsToWork)
            {
                shiftsWorked = 0;
                shiftsToWork = 0;
                currentJob = "";
                return true;
            }
            else
            {
                return false;
            }
        }
    }
