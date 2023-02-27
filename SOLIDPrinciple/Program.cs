using SOLIDPrinciple.Inversion_Dependencias;

IDatabase database = new OracleDB();

UserRepository UserRepository = new UserRepository(database);

UserRepository.GetUsersNames();

Console.ReadLine();

