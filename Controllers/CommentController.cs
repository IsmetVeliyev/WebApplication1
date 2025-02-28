﻿using Microsoft.AspNetCore.Mvc;
using System;
using WebApplication1.Repository;
namespace WebApplication1.Controllers
{
[Route("api/comment")]
[ApiController]
public class CommentController : ControllerBase
{
    private readonly ICommentRepository _commentRepo;

    public CommentController(ICommentRepository commentRepo)
    {
        _commentRepo = commentRepo;

    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var comments = await _commentRepo.GetAllAsync();
        var commentDto = comments.Select(s => s.ToCommentDto()).;

        return Ok(commentDto);
    }



}
}
