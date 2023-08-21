using System.Data;
using GalloTube.Interfaces;
using GalloTube.Models;
using MySql.Data.MySqlClient;

namespace GalloTube.Repositories;

public class VideoRepository : IVideoRepository
{
    readonly string connectionString = "server=localhost;port=3306;database=GalloTubedb;uid=root;pwd=''";

    public void Create(Video model)
    {
        MySqlConnection connection = new(connectionString);
        string sql = "insert into Video(Title, Description, VideoDate, Duration, Image, VideoFile) "
              + "values (@Title, @Description, @VideoDate, @Duration, @Image, @VideoFile)";
        MySqlCommand command = new(sql, connection)
        {
            CommandType = CommandType.Text
        };
        command.Parameters.AddWithValue("@Title", model.Title);
        command.Parameters.AddWithValue("@Description", model.Description);
        command.Parameters.AddWithValue("@VideoDate", model.VideoDate);
        command.Parameters.AddWithValue("@Duration", model.Duration);
        command.Parameters.AddWithValue("@Image", model.Image);
        command.Parameters.AddWithValue("@VideoFile", model.VideoFile);
        
        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
    }

    public void Delete(int? id)
    {
        MySqlConnection connection = new(connectionString);
        string sql = "delete from Video where Id = @Id";
        MySqlCommand command = new(sql, connection)
        {
            CommandType = CommandType.Text
        };
        command.Parameters.AddWithValue("@Id", id);
        
        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
    }

    public List<Video> ReadAll()
    {
        MySqlConnection connection = new(connectionString);
        string sql = "select * from Video";
        MySqlCommand command = new(sql, connection)
        {
            CommandType = CommandType.Text
        };
        
        List<Video> videos = new();
        connection.Open();
        MySqlDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
            Video video = new()
            {
                Id = reader.GetInt32("id"),
                Title = reader.GetString("title"),
                Description = reader.GetString("Description"),
                VideoDate = reader.GetInt16("VideoDate"),
                Duration = reader.GetInt16("duration"),
                Image = reader.GetString("image"),
                VideoFile = reader.GetString("VideoFile")
            };
            videos.Add(Video);
        }
        connection.Close();
        return videos;
    }

    public Video ReadById(int? id)
    {
        MySqlConnection connection = new(connectionString);
        string sql = "select * from Video where Id = @Id";
        MySqlCommand command = new(sql, connection)
        {
            CommandType = CommandType.Text
        };
        command.Parameters.AddWithValue("@Id", id);
        
        connection.Open();
        MySqlDataReader reader = command.ExecuteReader();
        reader.Read();
        if (reader.HasRows)
        {
            Video video = new()
            {
                Id = reader.GetInt32("id"),
                Title = reader.GetString("title"),
                Description = reader.GetString("Description"),
                VideoDate = reader.GetInt16("VideoDate"),
                Duration = reader.GetInt16("duration"),
                Image = reader.GetString("image"),
                VideoFile = reader.GetString("VideoFile")
            };
            connection.Close();
            return Video;
        }
        connection.Close();
        return null;
    }

    public void Update(Video model)
    {
        MySqlConnection connection = new(connectionString);
        string sql = "update Movie set "
                        + "Title = @Title, "
                        + "Description = @Description, "
                        + "VideoDate = @VideoDate, "
                        + "Duration = @Duration, "
                        + "Image = @Image "
                         + "VideoFile = @VideoFile "
                    + "where Id = @Id";
        MySqlCommand command = new(sql, connection)
        {
            CommandType = CommandType.Text
        };
        command.Parameters.AddWithValue("@Id", model.Id);
        command.Parameters.AddWithValue("@Title", model.Title);
        command.Parameters.AddWithValue("@Description", model.Description);
        command.Parameters.AddWithValue("@VideoDate", model.VideoDate);
        command.Parameters.AddWithValue("@Duration", model.Duration);
        command.Parameters.AddWithValue("@Image", model.Image);
        command.Parameters.AddWithValue("@VideoFile", model.VideoFile);
        
        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
    }
}
