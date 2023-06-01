import { INavData } from '@coreui/angular';

export const navItems: INavData[] = [
    {
        name: 'Dashboard',
        url: '/dashboard',
        iconComponent: { name: 'cil-home' },
        //badge: {
        //    color: 'info',
        //    text: 'NEW'
        //}
    },
    {
        name: 'Recruiter',
        url: '/recruiter',
        iconComponent: { name: 'cil-user' },
        children: [
            {
                name: 'Manage Recruiter',
                url: '/recruiter/manage-recruiter'
            },
            {
                name: 'Manage Role',
                url: '/recruiter/manage-role'
            },
            {
                name: 'Assign Recruiter Role',
                url: '/recruiter/assign-recruiter-role'
            },
            {
                name: 'Manage Profile',
                url: '/recruiter/manage-profile'
            },
            {
                name: 'Applicant Ownership',
                url: '/recruiter/applicant-ownership'
            },
            {
                name: 'Recruiter Profiles',
                url: '/recruiter/recruiter-profiles'
            },
            {
                name: 'Applicant Transfer',
                url: '/recruiter/applicant-transfer'
            },
            {
                name: 'User Performance',
                url: '/recruiter/user-performance'
            },
            {
                name: 'Usage Summary',
                url: '/recruiter/usage-summary'
            },
            {
                name: 'Assign Dept. To Position',
                url: '/recruiter/assign-dept-position'
            },
            {
                name: 'Recruiter History',
                url: '/recruiter/recruiter-history'
            },
            {
                name: 'Suspend Email Addresses',
                url: '/recruiter/suspend-email'
            },
            {
                name: 'Suspend Phone Numbers',
                url: '/recruiter/suspend-phone'
            },
        ]
    },
    {
        name: 'View',
        iconComponent: { name: 'cil-list' },
        children: [
            {
                name: 'Institution List',
                url: 'institution-list'
            },
            {
                name: 'Applicant List',
                url: 'applicant-list'
            },
            {
                name: 'Requirement Expiration',
                url: 'requirement-expiration'
            },
            {
                name: 'Time and Attendance',
                url: 'time-attendance'
            },
            {
                name: 'Contract List',
                url: 'contract-list'
            },
            {
                name: 'Import From App Portal',
                url: 'import-applicant'
            },
        ]
    },
    {
        name: 'Status',
        iconComponent: { name: 'cil-user' },
        children: [
            {
                name: 'Activated Applicant',
                url: 'activated-applicant'
            },
            {
                name: 'On-Boarding',
                url: 'on-boarding'
            },
            {
                name: 'Send Out',
                url: 'send-out'
            },
            {
                name: 'Interview',
                url: 'interview'
            },
            {
                name: 'Pending',
                url: 'pending'
            },
            {
                name: 'Hired',
                url: 'hired'
            },
        ]
    },
    {
        name: 'Information',
        iconComponent: { name: 'cil-menu' },
        children: [
            {
                name: 'Institution Type',
                url: 'institution-type'
            },
            {
                name: 'Contact Information',
                url: 'contact-information'
            },
            {
                name: 'Department Information',
                url: 'department-information'
            },
            {
                name: 'Location Information',
                url: 'location-information'
            },
            {
                name: 'Position Information',
                url: 'position-information'
            },
            {
                name: 'Position License Requirement',
                url: 'position-license-requirement'
            },
            {
                name: 'Language Information',
                url: 'language-information'
            },
            {
                name: 'Email Types',
                url: 'email-types'
            },
            {
                name: 'Zip Code',
                url: 'institution-type'
            },
            {
                name: 'Institution Type',
                url: 'institution-type'
            },
            {
                name: 'Institution Type',
                url: 'institution-type'
            },
            {
                name: 'Institution Type',
                url: 'institution-type'
            },
            {
                name: 'Institution Type',
                url: 'institution-type'
            },
            {
                name: 'Institution Type',
                url: 'institution-type'
            },
            {
                name: 'Institution Type',
                url: 'institution-type'
            },
            {
                name: 'Institution Type',
                url: 'institution-type'
            },
            {
                name: 'Institution Type',
                url: 'institution-type'
            }
        ]
    },
    {
        name: 'Job',
        iconComponent: { name: 'cil-user' },
        children: [
            {
                name: 'Job Openings',
                url: 'job-openings'
            },
            {
                name: 'Job Post',
                url: 'job-post'
            }
        ]
    },
    {
        name: 'Settings',
        iconComponent: { name: 'cil-settings' },
        children: [
            {
                name: 'User Settings',
                url: 'User Settings'
            },
            {
                name: 'User Mail Configuration',
                url: 'mail-configuration'
            },
            {
                name: 'User Mail Template',
                url: 'mail-template'
            }
        ]
    },
    {
        name: 'SMS',
        iconComponent: { name: 'cil-envelope-closed' },
        children: [
            {
                name: 'SMS History',
                url: 'sms-history'
            },
            {
                name: 'Batch SMS History',
                url: 'batch-sms-history'
            }
        ]
    },
    {
        name: 'Calendar',
        url: 'calendar',
        iconComponent: { name: 'cil-calendar' },
    },
    {
        name: 'Follow-up',
        url: 'follow-up',
        iconComponent: { name: 'cil-speech' },
    },
    {
        name: 'Emails',
        url: 'emails',
        iconComponent: { name: 'cil-envelope-closed' },
    },
    {
        name: 'Bulk Emails',
        url: 'bulk-emails',
        iconComponent: { name: 'cil-envelope-open' },
    },
    {
        name: 'Form',
        url: 'form',
        iconComponent: { name: 'cil-file' },
    }
];
