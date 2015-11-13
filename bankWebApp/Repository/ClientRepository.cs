using bankWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bankWebApp.Repository
{
    public class ClientRepository:IClientRepository
    {
        datamvcDataContext db;
        public ClientRepository()
        {
            db = new datamvcDataContext();
        }
        public List<clientTable> getAll()
        {
            return db.clientTable.ToList();
        }
        public void delete(int? id)
        {
            if (id != null)
            {
                var clientToDelete = db.clientTable.FirstOrDefault(client => client.clientsId == id);
                if (clientToDelete != null)
                {
                    db.clientTable.DeleteOnSubmit(clientToDelete);
                }
                db.SubmitChanges();
            }
        }
        public clientTable getById(int? id)
        {
            return db.clientTable.FirstOrDefault(client => client.clientsId == id);
        }
        public clientTable getByPassportId(string id)
        {
            return db.clientTable.FirstOrDefault(client => client.passportId == id);
        }
        public void insert(clientTable client)
        {
            db.clientTable.InsertOnSubmit(client);
            db.SubmitChanges();
        }
        public void edit(clientTable clientData)
        {
            var result = getById(clientData.clientsId);
            result.firstName = clientData.firstName;
            result.secondName = clientData.secondName;
            result.lastName = clientData.lastName;
            result.birthday = clientData.birthday;
            result.sex = clientData.sex;
            result.passportSeria = clientData.passportSeria;
            result.passportNumber = clientData.passportNumber;
            result.issuedBy = clientData.issuedBy;
            result.dateOfIssue = clientData.dateOfIssue;
            result.passportId = clientData.passportId;
            result.birthPlace = clientData.birthPlace;
            result.townLiving = clientData.townLiving;
            result.addressLiving = clientData.addressLiving;
            result.homePhone = clientData.homePhone;
            result.mobilePhone = clientData.mobilePhone;
            result.email = clientData.email;
            result.workPlace = clientData.workPlace;
            result.workPosition = clientData.workPosition;
            result.registrationTown = clientData.registrationTown;
            result.registrationAddress = clientData.registrationAddress;
            result.maritialStatus = clientData.maritialStatus;
            result.citizenship = clientData.citizenship;
            result.invalid = clientData.invalid;
            result.pensioner = clientData.pensioner;
            result.monthIncome = clientData.monthIncome;
            result.reservist = clientData.reservist;
            db.SubmitChanges();
        }
    }
}