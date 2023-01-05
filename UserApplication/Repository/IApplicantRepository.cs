﻿using UserLibrary;

namespace UserApplication.Repository
{
    public interface IApplicantRepository
    {
        public Guid Create(Applicant applicant);

        public Applicant GetById(Guid id);
    }
}