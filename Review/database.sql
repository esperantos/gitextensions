CREATE OR REPLACE FUNCTION update_review_time()
RETURNS trigger AS
$BODY$
   BEGIN
        NEW.update_time = now();
RETURN NEW;
END;
$BODY$
LANGUAGE plpgsql VOLATILE;

CREATE TABLE "public"."review_scheme" (
	"author" varchar NOT NULL PRIMARY KEY, 
	"reviewer" varchar
)
GO

CREATE TABLE "public"."review" (
	"commit_hash" varchar NOT NULL PRIMARY KEY, 
	"status" integer, 
	"comment" text, 
	"change_author" varchar, 
	"create_time" timestamp DEFAULT now(), 
	"update_time" timestamp DEFAULT now()
)
GO

CREATE TRIGGER "update_review"
	BEFORE UPDATE
	ON review
	FOR EACH ROW
	EXECUTE PROCEDURE update_review_time();
GO
