﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSharp.Choices;

namespace Question.Domain.CreateProfileWorkflow
{
    [AsChoice]
    public static partial class CreateQuestionResult
    {
        public interface ICreateQuestionResult { }

        public class QuestionCreated : ICreateQuestionResult
        {
            public string Title_q { get; private set; }
            public string Description_q { get; private set; }

            public ProfileCreated(string title_q, string description_q)
            {
                Title_q = title_q;
                Description_q = description_q;
            }
        }

        public class QuestionNotCreated : ICreateQuestionResult
        {
            public string Reason { get; set; }

            public QuestionNotCreated(string reason)
            {
                Reason = reason;
            }
        }

        public class QuestionValidationFailed : ICreateQuestionResult
        {
            public IEnumerable<string> ValidationErrors { get; private set; }

            public QuestionValidationFailed(IEnumerable<string> errors)
            {
                ValidationErrors = errors.AsEnumerable();
            }
        }
    }
}
