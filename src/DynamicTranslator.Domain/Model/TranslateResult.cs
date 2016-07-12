﻿using System;
using System.Runtime.Serialization;

namespace DynamicTranslator.Domain.Model
{
    [Serializable]
    public class TranslateResult
    {
        [DataMember]
        public bool IsSucess { get; set; }

        [DataMember]
        public Maybe<string> ResultMessage { get; set; }

        public TranslateResult() : this(true, new Maybe<string>()) {}

        public TranslateResult(bool isSucess, Maybe<string> resultMessage)
        {
            IsSucess = isSucess;
            ResultMessage = resultMessage;
        }
    }
}