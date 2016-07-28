var sql = require("seriate")

module.exports = {
    
  // Get all appointments from the database
  index: function(req, res) {
    sql.execute( {
        name: "selectFromReference",
        preparedSql: "SELECT StartID, EndID FROM Reference",
    }).then( function( data ) {
        console.log("Got It!");
        console.log(data);
        res.json(data);
    }, function( err ) {
        console.log( err );
    });
  }
}