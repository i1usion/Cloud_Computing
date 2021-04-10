const PeopleDbContext = require('../DataAccess/db-context');
const common = require('./../common');

const FirstName = req.query.FirstName
const LastName = req.query.LastName

module.exports = async function (context, req) {
    await common.functionWrapper(context, req, async (body) => {
        const connectionString = process.env['PeopleDb'];
        const peopleDb = new PeopleDbContext(connectionString, context.log);
        
        //body.people = await peopleDb.getPeople();

        //GET SINGLE PERSON
        //body.people = await peopleDb.getPerson(FirstName);

        //DELETE SINGLE PERSON
        //body.people = await peopleDb.deletePerson(FirstName);

        //CREATE PERSON
        body.people = await peopleDb.createPerson(FirstName);
    });
};