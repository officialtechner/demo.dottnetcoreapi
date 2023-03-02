/*
SP:

DELIMITER //
CREATE PROCEDURE sp_testCOMPANY_INPUT(
     p_RECORD_PER_PAGE INT,
    p_CURRENTPAGE  INT,
  OUT p_TOTALPAGE INT,
    OUT p_TOTALRECORD INT
  )
BEGIN
 DECLARE v_OFFSET INT DEFAULT 0;
DECLARE v_LIMIT INT DEFAULT 10;
  IF p_RECORD_PER_PAGE = 0 AND p_CURRENTPAGE = 0 THEN
      SET p_RECORD_PER_PAGE = 10;
    SET p_CURRENTPAGE = 1;
    ELSE
      SET v_LIMIT = p_RECORD_PER_PAGE;
    SET v_OFFSET = p_RECORD_PER_PAGE * (p_CURRENTPAGE - 1);
    END IF;
  SELECT * FROM `users` LIMIT v_LIMIT  OFFSET  v_OFFSET ;
      select v_LIMIT AS "limit",  v_OFFSET AS "offset";
    SELECT count(*) into p_TOTALRECORD FROM `users`;
      SELECT CEIL(p_TOTALRECORD/p_RECORD_PER_PAGE) into p_TOTALPAGE;
END//
DELIMITER ;


*/


            MySqlConnection conn = new MySqlConnection(Environment.GetEnvironmentVariable("connstr"));
            conn.Open();

MySqlCommand cmd = new MySqlCommand("sp_testCOMPANY_INPUT", conn);
cmd.CommandType = CommandType.StoredProcedure;

cmd.Parameters.AddWithValue("@p_RECORD_PER_PAGE", 1);
            cmd.Parameters.AddWithValue("@p_CURRENTPAGE", 1);
            cmd.Parameters.Add("@p_TOTALPAGE", System.Data.DbType.Int32);
            cmd.Parameters["@p_TOTALPAGE"].Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@p_TOTALRECORD", System.Data.DbType.Int32);
            cmd.Parameters["@p_TOTALRECORD"].Direction = ParameterDirection.Output;

cmd.ExecuteNonQuery();
 MySqlDataReader row = cmd.ExecuteReader();
 while (row.Read())
            {

                Console.WriteLine(row[0].ToString());
               Console.WriteLine(row[1].ToString());
               Console.WriteLine(row[2].ToString());
               Console.WriteLine(row[3].ToString());
               Console.WriteLine(row[4].ToString());
              
            }
Console.WriteLine("Employee number ?p_TOTALPAGE: "+cmd.Parameters["@p_TOTALPAGE"].Value);
 Console.WriteLine("Employee number ?p_TOTALRECORD: "+cmd.Parameters["@p_TOTALRECORD"].Value);
