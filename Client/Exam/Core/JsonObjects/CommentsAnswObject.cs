﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Core.JsonObjects
{
    public class CommentsAnswObject
    {
        public bool successful { get; set; }
        public CommentObject[] comments { get; set; }
    }
}
