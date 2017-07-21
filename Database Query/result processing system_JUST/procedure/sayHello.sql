CREATE OR REPLACE PROCEDURE 
        sayHello (name IN VARCHAR2, greeting OUT VARCHAR2) 
    AS
        BEGIN
            greeting := 'Hello ' || name;
        END;
/