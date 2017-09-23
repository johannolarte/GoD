(function () {
    'use strict'

    var serviceId = 'Constants'

    angular.module('services.common').service(serviceId, [Constants])

    function Constants() {

        var _API = {}


        _API.baseUrl = "http://localhost:59095"


        _API.playersUrl = _API.baseUrl + "/Players"


        // Personal
        _API.employeePersonalInfoUrl = _API.baseUrl + "/Employee/{0}/personalInfo" //{identification}
        _API.employeesUrl = _API.baseUrl + "/Employee/{0}" //{identification}
        _API.employeeFamilyInfoUrl = _API.baseUrl + "/Employee/{0}/familyInfo" //{identification}
        _API.employeeMaritalStatusUrl = _API.baseUrl + "/MaritalStatus"
        _API.employeeHomeTypesUrl = _API.baseUrl + "/HomeType"
        _API.employeeSocialStratumUrl = _API.baseUrl + "/SocialStratum"
        _API.gendersUrl = _API.baseUrl + "/Gender"
        _API.employeeProfileImageUrl = _API.baseUrl + "/Employee/{0}/profileImage" //{identification}
        //

        // Emergency Contact
        _API.emergencyContactUrl = _API.baseUrl + "/EmergencyContact"
        _API.emergencyContactUrlDetail = _API.baseUrl + "/EmergencyContact/{0}/emergencyContactInfo" //{identification}
        //

        // Vehicle
        _API.vehiclesUrl = _API.baseUrl + "/Vehicle"
        _API.vehiclesByIdUrl = _API.baseUrl + "/Vehicle/{0}" //{identification}
        _API.vehicleDetailUrl = _API.baseUrl + "/Vehicle/{0}/vehicleInfo" //{identification}
        _API.vehicleTypeUrl = _API.baseUrl + "/VehicleType"
        //

        // Formal Education
        _API.educationUrl = _API.baseUrl + "/Education"
        _API.educationByIdUrl = _API.baseUrl + "/Education/{0}" //{educationDetailId}
        _API.educationByEmployeeUrl = _API.baseUrl + "/Education/{0}/formalEducationInfo" //{identification}
        _API.educationEmployeeDetailUrl = _API.baseUrl + "/Education/{0}/formalEducationInfo/{1}" //{identification}, {educationDetailId}
        _API.educationTypeUrl = _API.baseUrl + "/EducationType"
        //

        // Certification Courses
        _API.certificationCoursesUrl = _API.baseUrl + "/CertificationCourses"
        _API.certificationByIdUrl = _API.baseUrl + "/CertificationCourses/{0}" //{certificationCourseId}
        _API.certificationCoursesByEmployeeUrl = _API.baseUrl + "/CertificationCourses/{0}/certificationCoursesInfo" // {identification}
        _API.certificationCoursesDetailUrl = _API.baseUrl + "/CertificationCourses/{0}/certificationCoursesInfo/{1}" // {identification}, {certificationCourseId}
        //

        // Technical Certifications
        _API.technicalCertificationsUrl = _API.baseUrl + "/TechnicalCertifications"
        _API.technicalCertificationsByIdUrl = _API.baseUrl + "/TechnicalCertifications/{0}" //{technicalCertificationId}
        _API.technicalCertificationsByEmployeeUrl = _API.baseUrl + "/TechnicalCertifications/{0}/technicalCertificationsInfo" // {identification}
        _API.technicalCertificationsDetailUrl = _API.baseUrl + "/TechnicalCertifications/{0}/technicalCertificationsInfo/{1}" // {identification}, {technicalCertificationId}
        //

        // Foreign Languages
        _API.foreignLanguageSkillsUrl = _API.baseUrl + "/ForeignLanguageSkills"
        _API.foreignLanguageSkillsByIdUrl = _API.baseUrl + "/ForeignLanguageSkills/{0}" //{foreignLanguageSkillId}
        _API.foreignLanguageSkillsByEmployeeUrl = _API.baseUrl + "/ForeignLanguageSkills/{0}/foreignLanguageSkillsInfo" // {identification}
        _API.foreignLanguageSkillsDetailUrl = _API.baseUrl + "/ForeignLanguageSkills/{0}/foreignLanguageSkillsInfo/{1}" // {identification}, {foreignLanguageSkillId}
        _API.languagesUrl = _API.baseUrl + "/Languages"
        _API.languageCertificatesUrl = _API.baseUrl + "/LanguageCertificates"
        //

        // Work Experience
        _API.workExperienceUrl = _API.baseUrl + "/WorkExperience"
        _API.workExperienceByIdUrl = _API.baseUrl + "/WorkExperience/{0}" //{workExperienceId}
        _API.workExperienceByEmployeeUrl = _API.baseUrl + "/WorkExperience/{0}/workExperienceInfo" // {identification}
        _API.workExperienceDetailUrl = _API.baseUrl + "/WorkExperience/{0}/workExperienceInfo/{1}" // {identification}, {workExperienceId}
        //

        // Children
        _API.childrenUrl = _API.baseUrl + "/Children"
        _API.childrenByIdUrl = _API.baseUrl + "/Children/{0}" //{childrenId}
        _API.childrenByEmployeeUrl = _API.baseUrl + "/Children/{0}/childrenInfo" // {identification}
        _API.childrenDetailUrl = _API.baseUrl + "/Children/{0}/childrenInfo/{1}" // {identification}, {childrenId}

        //Gamification
        _API.gamificationUrl = _API.baseUrl + '/Gamification'
        _API.profileStateUrl = _API.baseUrl + '/Gamification/Profile/{0}/State' //{identification}

        //Documents
        _API.documentUrl = _API.baseUrl + '/Documents/{0}' //{documentId}
        _API.documentsUrl = _API.baseUrl + '/Documents'
        //_API.documentType = _API.baseUrl + '/DocumentType/{0}/Resource/{1}' // {documentTypeName}, {resourceName}
        _API.documentType = _API.baseUrl + '/DocumentType/Resource' // {documentTypeName}, {resourceName}
        _API.documentTypesUrl = _API.baseUrl + '/DocumentTypes'
        //_API.documentTypesByName = _API.baseUrl + '/Resource/{0}/DocumentTypesName/{1}' // {resourceName},{documentName}
        _API.documentTypesByName = _API.baseUrl + '/Resource/DocumentTypesName'
        _API.employeeDocumentUrl = _API.baseUrl + '/Employee/{0}/Documents/{1}' //{identification},{documentId}
        _API.employeeDocumentsUrl = _API.baseUrl + '/Employee/{0}/Documents' //{identification}
        _API.employeeDocumentTypesUrl = _API.baseUrl + '/Employee/{0}/DocumentTypes/{1}' //{identification},{documentTypeId}

        // Reporting Employee Cv
        _API.cvGetReport = _API.baseUrl + "/ReportingCv/{0}/GetEmployeeCvReport/{1}" // {identification}, {report}
        _API.cvExportReport = _API.baseUrl + "/ReportingCv/{0}/ExportEmployeeCvReport/{1}" // {identification}, {report}
        //_API.cvReportSearchName = _API.baseUrl + "/ReportingCv/{0}/GetEmployeeIdFullNameCvReport" // {searchName}
        _API.cvReportSearchName = _API.baseUrl + "/ReportingCv/GetEmployeeIdFullNameCvReport"
        _API.cvDownloadReportAttachment = _API.baseUrl + "/ReportingCv/{0}/EmployeeCvReportZip/{1}" // {identification}, {report}
        //

        // Reporting Dynamic
        _API.dynamicReportPersonalInfo = _API.baseUrl + "/ReportingDynamic"
        _API.dynamicReportFormalEducationInfo = _API.baseUrl + "/ReportingDynamic/{0}/GetFormalEducation"
        _API.dynamicReportCertificationCoursesInfo = _API.baseUrl + "/ReportingDynamic/{0}/GetCertificationCourses"
        _API.dynamicReportTechnicalCertificationsInfo = _API.baseUrl + "/ReportingDynamic/{0}/GetTechnicalCertifications"
        _API.dynamicReportForeignLanguagesInfo = _API.baseUrl + "/ReportingDynamic/{0}/GetForeignLanguages"
        _API.dynamicReportWorkExperiencesInfo = _API.baseUrl + "/ReportingDynamic/{0}/GetWorkExperiences"
        _API.dynamicReportChildrenInfo = _API.baseUrl + "/ReportingDynamic/{0}/GetChildren"
        //

        /************* Skills Evaluation (Assessment) *************/
        // Production URL base http://localhost/HojasVida/WebApi
        _API.evaluationBaseUrl = window.location.origin.includes("localhost") ? "http://localhost:50107" :
                        window.location.origin + "/Evaluation/WebApi"
        _API.evalEmployeesUrl = _API.evaluationBaseUrl + "/Employee/{0}/employeeInfo" // {identification}
        /************* End Skills Evaluation (Assessment) *************/

        var _globals = {
            appBodySelector: '#appBody'
        }

        var _localStorage = {
            sessionTokenName: 'session_token',
            appUserName: 'app_user',
            identityDataName: 'identityData'
        }

        var _messages = {
            forbiddenError: 'No tienes los permisos suficientes para que tu solicitud sea procesada',
            notFoundError: 'No hemos podido encontrar el recurso que se solicitó',
            unexpectedError: 'Ha ocurrido un error que no esperabamos. Vuelve a intentarlo',
            upload_images_extensions_validation: 'Solo se permiten adjuntar archivos con extensiones {0}',
            upload_images_size_validation: 'Solo se permiten adjuntar archivos de tamaño igual o menor a {0} MB',
            education_name_not_found: '¿Nos ayudas a registrarlo?'
        }

        var _router = {
            stateRound: 'app.round',
            stateHome: 'app.home',
            urlHome: '/home',
            stateResources: 'app.resources',
            evalStateHome: 'evaldesemp'
        }

        var _templates = {
            loadingTemplate: '<style>md-backdrop.md-opaque {background-color: white;} </style>\
                             <md-dialog style="background-color: transparent; box-shadow:none"> \
                                <div layout="row" \
                                     layout-sm="column" \
                                     layout-align="center center" \
                                     style="overflow: hidden" \
                                     aria-label="wait"> \
                                    <md-progress-circular md-mode="indeterminate" class="md-hue-2" md-diameter="25px"> \
                                    </md-progress-circular> \
                                </div> \
                             </md-dialog>',
            errorTemplate: '<p style="padding:10px; text-align: center;">{{error.message}}</p>'
        }

        var _uploadLocalization = {
            select: 'selecciona un archivo',
            cancel: 'cancelar',
            dropFilesHere: 'puedes soltar aquí el archivo que deseas subir',
            headerStatusUploaded: 'Finalizado',
            headerStatusUploading: 'subiendo',
            remove: 'eliminar',
            retry: 'reintentar',
            statusFailed: 'error'
        }

        return {
            API: _API,
            GLOBALS: _globals,
            LOCAL_STORAGE: _localStorage,
            ROUTER: _router,
            TEMPLATES: _templates,
            MESSAGES: _messages,
            UPLOAD_LOCALIZATION: _uploadLocalization
        }
    }
})()