﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Data.Model
{
    class TaskDetailDTO
    {
        public Int64 task_id { get; set; }

        public Int64? parent_id { get; set; }

        public string task { get; set; }
        public string parent_task { get; set; }

        public DateTime start_date { get; set; }

        public DateTime end_date { get; set; }

        public int priority { get; set; }
    }
}
